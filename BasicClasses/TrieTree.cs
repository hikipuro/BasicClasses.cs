using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClasses {
	[Serializable]
	public class TrieTree<T> {
		public readonly Node Root;

		public T this[string key] {
			get {
				Node node = Root.Search(key);
				if (node == null) {
					return default(T);
				}
				return node.Value;
			}
			set {
				Root.Add(key, value);
			}
		}

		public bool IsEmpty {
			get { return Root.Children.Count <= 0; }
		}

		public int Count {
			get {
				int count = Root.Children.Count;
				Queue<Node> queue = new Queue<Node>();
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
			}
		}

		public TrieTree() {
			Root = new Node(char.MinValue);
		}

		public void Traverse(Func<Node, bool> callback) {
			Root.Traverse(callback);
		}

		public Node Search(string word) {
			return Root.Search(word);
		}

		public bool Add(string word, T value) {
			return Root.Add(word, value);
		}

		public bool Remove(string word) {
			return Root.Remove(word);
		}

		[Serializable]
		public class Node {
			public readonly ushort Key;
			public T Value;
			public Node Parent;
			public readonly Dictionary<ushort, Node> Children;

			public Node this[char key] {
				get {
					if (Children.TryGetValue(key, out Node node)) {
						return node;
					}
					return null;
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
				Node node = this;
				while (node != null) {
					builder.Insert(0, (char)node.Key);
					node = node.Parent;
					if (node.Key == char.MinValue) {
						break;
					}
				}
				return builder.ToString();
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
				Node node = GetChild(key);
				if (node != null) {
					node.Parent = null;
					Children.Remove(key);
				}
				return node;
			}

			public Node RemoveChild(Node node) {
				if (node == null) {
					return null;
				}
				foreach (KeyValuePair<ushort, Node> child in Children) {
					if (child.Value != node) {
						continue;
					}
					child.Value.Parent = null;
					Children.Remove(child.Key);
					return child.Value;
				}
				return null;
			}

			public void Traverse(Func<Node, bool> callback) {
				if (callback == null) {
					throw new ArgumentNullException("callback");
				}
				Queue<Node> queue = new Queue<Node>();
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
			}

			public Node Search(string word) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return null;
				}
				Node node = this;
				foreach (char key in word) {
					node = node[key];
					if (node == null) {
						return null;
					}
				}
				return node;
			}

			public bool Add(string word, T value) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return false;
				}
				Node node = this;
				foreach (char key in word) {
					if (node.HasChild(key)) {
						node = node[key];
						continue;
					}
					Node newNode = new Node(key);
					newNode.Parent = node;
					node.AddChild(key, newNode);
					node = newNode;
				}
				if (node == this) {
					return false;
				}
				node.Value = value;
				return true;
			}

			public bool Remove(string word) {
				if (word == null) {
					throw new ArgumentNullException("word");
				}
				if (word == string.Empty) {
					return false;
				}
				Node node = this;
				foreach (char key in word) {
					if (node.HasChild(key)) {
						node = node[key];
						continue;
					}
					return false;
				}
				if (node.Children.Count <= 0) {
					node.Parent.RemoveChild((char)node.Key);
				} else {
					node.Value = default(T);
				}
				return true;
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
