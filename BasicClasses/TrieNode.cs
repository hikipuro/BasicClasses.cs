using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClasses {
	[Serializable]
	public class TrieNode<T> {
		public readonly string Key;
		public T Value;
		public TrieNode<T> Parent;
		public readonly Dictionary<string, TrieNode<T>> Children;

		public TrieNode<T> this[string key] {
			get {
				if (Children.TryGetValue(key, out TrieNode<T> node)) {
					return node;
				}
				return null;
			}
		}

		public TrieNode(string key) {
			Key = key;
			Children = new Dictionary<string, TrieNode<T>>();
		}

		public string GetWord() {
			StringBuilder builder = new StringBuilder();
			TrieNode<T> node = this;
			while (node != null) {
				builder.Insert(0, node.Key);
				node = node.Parent;
			}
			return builder.ToString();
		}

		public bool HasChild(string key) {
			if (key == null) {
				return false;
			}
			return Children.ContainsKey(key);
		}

		public bool HasChild(TrieNode<T> node) {
			if (node == null) {
				return false;
			}
			return Children.ContainsValue(node);
		}

		public TrieNode<T> GetChild(string key) {
			if (key == null) {
				return null;
			}
			if (Children.TryGetValue(key, out TrieNode<T> node)) {
				return node;
			}
			return null;
		}

		public void AddChild(string key, TrieNode<T> node) {
			if (key == null) {
				throw new ArgumentNullException("key");
			}
			if (node == null) {
				throw new ArgumentNullException("node");
			}
			Children.Add(key, node);
		}

		public TrieNode<T> RemoveChild(string key) {
			if (key == null) {
				return null;
			}
			TrieNode<T> node = GetChild(key);
			if (node != null) {
				node.Parent = null;
				Children.Remove(key);
			}
			return node;
		}

		public TrieNode<T> RemoveChild(TrieNode<T> node) {
			if (node == null) {
				return null;
			}
			foreach (KeyValuePair<string, TrieNode<T>> child in Children) {
				if (child.Value != node) {
					continue;
				}
				child.Value.Parent = null;
				Children.Remove(child.Key);
				return child.Value;
			}
			return null;
		}

		public void Traverse(TrieTree<T>.TraverseCallback callback) {
			if (callback == null) {
				throw new ArgumentNullException("callback");
			}
			Queue<TrieNode<T>> queue = new Queue<TrieNode<T>>();
			foreach (TrieNode<T> child in Children.Values) {
				queue.Enqueue(child);
			}
			while (queue.Count > 0) {
				TrieNode<T> node = queue.Dequeue();
				if (callback(node) == false) {
					break;
				}
				foreach (TrieNode<T> child in node.Children.Values) {
					queue.Enqueue(child);
				}
			}
		}

		public TrieNode<T> Search(string word) {
			if (word == null) {
				throw new ArgumentNullException("word");
			}
			if (word == string.Empty) {
				return null;
			}
			TrieNode<T> node = this;
			foreach (string key in EnumerateKey(word)) {
				node = node[key];
				if (node == null) {
					return null;
				}
			}
			return node;
		}

		public bool Insert(string word, T value) {
			if (word == null) {
				throw new ArgumentNullException("word");
			}
			if (word == string.Empty) {
				return false;
			}
			TrieNode<T> node = this;
			foreach (string key in EnumerateKey(word)) {
				if (node.HasChild(key)) {
					node = node[key];
					continue;
				}
				TrieNode<T> newNode = new TrieNode<T>(key);
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

		public override string ToString() {
			return string.Format("{0}, {1}", Key, Value);
		}

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
	}
}
