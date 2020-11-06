using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicClasses {
	[Serializable]
	public class TrieTree<T> {
		public readonly Node Root;

		public T this[string key] {
			get {
				if (key == null || key == string.Empty) {
					return default(T);
				}
				try {
					Monitor.Enter(Root);
					Node node = Root;
					foreach (char ch in key) {
						if (node.Children.TryGetValue(ch, out node)) {
							continue;
						}
						return default(T);
					}
					return node.Value;
				} finally {
					Monitor.Exit(Root);
				}
			}
			set {
				if (key == null || key == string.Empty) {
					return;
				}
				try {
					Monitor.Enter(Root);
					Node node = Root;
					foreach (char ch in key) {
						if (node.Children.TryGetValue(ch, out Node child)) {
							node = child;
							continue;
						}
						Node newNode = new Node(ch);
						newNode.Parent = node;
						node.Children.Add(ch, newNode);
						node = newNode;
					}
					node.Value = value;
				} finally {
					Monitor.Exit(Root);
				}
			}
		}

		public bool IsEmpty {
			get { return Root.Children.Count <= 0; }
		}

		public int Count {
			get {
				Queue<Node> queue = new Queue<Node>();
				try {
					Monitor.Enter(Root);
					int count = Root.Children.Count;
					foreach (Node child in Root.Children.Values) {
						queue.Enqueue(child);
					}
					while (queue.Count > 0) {
						Node node = queue.Dequeue();
						count += node.Children.Count;
						foreach (Node child in node.Children.Values) {
							queue.Enqueue(child);
						}
					}
					return count;
				} finally {
					Monitor.Exit(Root);
				}
			}
		}

		public TrieTree() {
			Root = new Node(char.MinValue);
		}

		public void Clear() {
			try {
				Monitor.Enter(Root);
				foreach (Node node in Root.Children.Values) {
					node.Parent = null;
				}
				Root.Children.Clear();
			} finally {
				Monitor.Exit(Root);
			}
		}

		public void Traverse(Func<Node, bool> callback) {
			Root.Traverse(callback);
		}

		public Node Search(string word) {
			if (word == null) {
				throw new ArgumentNullException("word");
			}
			if (word == string.Empty) {
				return null;
			}
			try {
				Monitor.Enter(Root);
				Node node = Root;
				foreach (char key in word) {
					if (node.Children.TryGetValue(key, out node)) {
						continue;
					}
					return null;
				}
				return node;
			} finally {
				Monitor.Exit(Root);
			}
		}

		public bool Add(string word, T value) {
			if (word == null) {
				throw new ArgumentNullException("word");
			}
			if (word == string.Empty) {
				return false;
			}
			try {
				Monitor.Enter(Root);
				Node node = Root;
				foreach (char key in word) {
					if (node.Children.TryGetValue(key, out Node child)) {
						node = child;
						continue;
					}
					Node newNode = new Node(key);
					newNode.Parent = node;
					node.Children.Add(key, newNode);
					node = newNode;
				}
				node.Value = value;
				return true;
			} finally {
				Monitor.Exit(Root);
			}
		}

		public bool Remove(string word) {
			if (word == null) {
				throw new ArgumentNullException("word");
			}
			if (word == string.Empty) {
				return false;
			}
			try {
				Monitor.Enter(Root);
				Node node = Root;
				foreach (char key in word) {
					if (node.Children.TryGetValue(key, out node)) {
						continue;
					}
					return false;
				}
				if (node.Children.Count <= 0) {
					do {
						Node parent = node.Parent;
						if (parent == null) {
							break;
						}
						parent.Children.Remove((char)node.Key);
						node.Parent = null;
						node = parent;
					} while (node.Children.Count <= 0);
				} else {
					node.Value = default(T);
				}
			} finally {
				Monitor.Exit(Root);
			}
			return true;
		}

		[Serializable]
		public class Node {
			public readonly ushort Key;
			public T Value;
			public Node Parent;
			public readonly Dictionary<ushort, Node> Children;

			public Node this[char key] {
				get {
					try {
						Monitor.Enter(this);
						if (Children.TryGetValue(key, out Node node)) {
							return node;
						}
						return null;
					} finally {
						Monitor.Exit(this);
					}
				}
			}

			public bool IsLeaf {
				get { return Children.Count <= 0; }
			}

			public Node(char key) {
				Key = key;
				Children = new Dictionary<ushort, Node>();
			}

			public string GetWord() {
				StringBuilder builder = new StringBuilder();
				try {
					Monitor.Enter(this);
					Node node = this;
					do {
						if (node.Key == char.MinValue) {
							break;
						}
						builder.Insert(0, (char)node.Key);
						node = node.Parent;
					} while (node != null);
					return builder.ToString();
				} finally {
					Monitor.Exit(this);
				}
			}

			public bool HasChild(char key) {
				//if (key == null) {
				//	return false;
				//}
				return Children.ContainsKey(key);
			}

			public bool HasChild(Node node) {
				if (node == null) {
					return false;
				}
				return Children.ContainsValue(node);
			}

			public Node GetChild(char key) {
				//if (key == null) {
				//	return null;
				//}
				if (Children.TryGetValue(key, out Node node)) {
					return node;
				}
				return null;
			}

			public void AddChild(char key, Node node) {
				//if (key == null) {
				//	throw new ArgumentNullException("key");
				//}
				if (node == null) {
					throw new ArgumentNullException("node");
				}
				Children.Add(key, node);
			}

			public Node RemoveChild(char key) {
				//if (key == null) {
				//	return null;
				//}
				try {
					Monitor.Enter(this);
					Node node;
					Children.TryGetValue(key, out node);
					if (node != null) {
						node.Parent = null;
						Children.Remove(key);
					}
					return node;
				} finally {
					Monitor.Exit(this);
				}
			}

			public Node RemoveChild(Node node) {
				if (node == null) {
					return null;
				}
				try {
					Monitor.Enter(this);
					foreach (KeyValuePair<ushort, Node> child in Children) {
						if (child.Value != node) {
							continue;
						}
						child.Value.Parent = null;
						Children.Remove(child.Key);
						return child.Value;
					}
				} finally {
					Monitor.Exit(this);
				}
				return null;
			}

			public void Traverse(Func<Node, bool> callback) {
				if (callback == null) {
					throw new ArgumentNullException("callback");
				}
				Queue<Node> queue = new Queue<Node>();
				try {
					Monitor.Enter(this);
					foreach (Node child in Children.Values) {
						queue.Enqueue(child);
					}
					while (queue.Count > 0) {
						Node node = queue.Dequeue();
						if (callback(node) == false) {
							break;
						}
						foreach (Node child in node.Children.Values) {
							queue.Enqueue(child);
						}
					}
				} finally {
					Monitor.Exit(this);
				}
			}

			public Node Search(string word) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return null;
				}
				try {
					Monitor.Enter(this);
					Node node = this;
					foreach (char key in word) {
						if (node.Children.TryGetValue(key, out node)) {
							continue;
						}
						return null;
					}
					return node;
				} finally {
					Monitor.Exit(this);
				}
			}

			public bool Add(string word, T value) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return false;
				}
				try {
					Monitor.Enter(this);
					Node node = this;
					foreach (char key in word) {
						if (node.Children.TryGetValue(key, out Node child)) {
							node = child;
							continue;
						}
						Node newNode = new Node(key);
						newNode.Parent = node;
						node.Children.Add(key, newNode);
						node = newNode;
					}
					node.Value = value;
					return true;
				} finally {
					Monitor.Exit(this);
				}
			}

			public bool Remove(string word) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return false;
				}
				try {
					Monitor.Enter(this);
					Node node = this;
					foreach (char key in word) {
						if (node.Children.TryGetValue(key, out node)) {
							continue;
						}
						return false;
					}
					if (node.Children.Count <= 0) {
						do {
							Node parent = node.Parent;
							if (parent == null) {
								break;
							}
							parent.Children.Remove((char)node.Key);
							node.Parent = null;
							node = parent;
						} while (node.Children.Count <= 0);
					} else {
						node.Value = default(T);
					}
					return true;
				} finally {
					Monitor.Exit(this);
				}
			}

			public override string ToString() {
				return string.Format("{0}, {1}", Key, Value);
			}

			/*
			protected static IEnumerable<string> EnumerateKey(string text) {
				char highSurrogate = char.MinValue;
				foreach (char ch in text) {
					if (highSurrogate != char.MinValue) {
						if (char.IsLowSurrogate(ch)) {
							yield return string.Concat(highSurrogate, ch);
						} else {
							throw new InvalidOperationException(
								"found invalid surrogate pair"
							);
						}
						highSurrogate = char.MinValue;
						continue;
					}
					if (char.IsHighSurrogate(ch)) {
						highSurrogate = ch;
						continue;
					}
					yield return ch.ToString();
				}
				if (highSurrogate != char.MinValue) {
					throw new InvalidOperationException(
						"found invalid surrogate pair"
					);
				}
			}
			*/
		}
	}
}
