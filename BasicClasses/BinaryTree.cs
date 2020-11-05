using System;
using System.Collections.Generic;

namespace BasicClasses {
	[Serializable]
	public class BinaryTree<TKey, TValue> where TKey: IComparable<TKey> {
		public Node Root;

		public TValue this[TKey key] {
			get {
				if (Root == null) {
					return default(TValue);
				}
				Node node = Root.Search(key);
				if (node == null) {
					return default(TValue);
				}
				return node.Value;
			}
			set {
				if (Root == null) {
					Root = new Node(key, value);
					return;
				}
				Root.Add(key, value);
			}
		}

		public BinaryTree() {
		}

		public void Clear() {
			if (Root == null) {
				return;
			}
			if (Root.LeftChild != null) {
				Root.LeftChild.Parent = null;
			}
			if (Root.RightChild != null) {
				Root.RightChild.Parent = null;
			}
			Root = null;
		}

		public void Traverse(Func<Node, bool> callback) {
			if (Root == null) {
				return;
			}
			Root.Traverse(callback);
		}

		public Node Search(TKey key) {
			if (Root == null) {
				return null;
			}
			return Root.Search(key);
		}

		public void Add(TKey key, TValue value) {
			if (Root == null) {
				Root = new Node(key, value);
				return;
			}
			Root.Add(key, value);
		}

		public bool Remove(TKey key) {
			if (Root == null) {
				return false;
			}
			return Root.Remove(key);
		}

		[Serializable]
		public class Node {
			public readonly TKey Key;
			public TValue Value;
			public Node Parent;
			public Node LeftChild;
			public Node RightChild;

			public bool IsLeaf {
				get { return LeftChild == null && RightChild == null; }
			}

			public Node(TKey key, TValue value) {
				Key = key;
				Value = value;
			}

			public Node RemoveChild(TKey key) {
				int compare = Key.CompareTo(key);
				if (compare == 0) {
					return null;
				}
				if (compare < 0) {
					if (RightChild == null) {
						return null;
					}
					if (RightChild.Key.CompareTo(key) == 0) {
						Node node = RightChild;
						RightChild = null;
						return node;
					}
				} else {
					if (LeftChild == null) {
						return null;
					}
					if (LeftChild.Key.CompareTo(key) == 0) {
						Node node = LeftChild;
						LeftChild = null;
						return node;
					}
				}
				return null;
			}

			public void Traverse(Func<Node, bool> callback) {
				if (callback == null) {
					throw new ArgumentNullException("callback");
				}
				Queue<Node> queue = new Queue<Node>();
				queue.Enqueue(this);
				while (queue.Count > 0) {
					Node node = queue.Dequeue();
					if (callback(node) == false) {
						break;
					}
					if (node.LeftChild != null) {
						queue.Enqueue(node.LeftChild);
					}
					if (node.RightChild != null) {
						queue.Enqueue(node.RightChild);
					}
				}
			}

			public Node Search(TKey key) {
				Node node = this;
				do {
					int compare = node.Key.CompareTo(key);
					if (compare == 0) {
						return node;
					}
					if (compare < 0) {
						node = node.RightChild;
					} else {
						node = node.LeftChild;
					}
				} while (node != null);
				return null;
			}

			public void Add(TKey key, TValue value) {
				Node node = this;
				do {
					int compare = node.Key.CompareTo(key);
					if (compare == 0) {
						node.Value = value;
						break;
					}
					if (compare < 0) {
						if (node.RightChild != null) {
							node = node.RightChild;
							continue;
						}
						node.RightChild = new Node(key, value);
						node.RightChild.Parent = node;
						break;
					} else {
						if (node.LeftChild != null) {
							node = node.LeftChild;
							continue;
						}
						node.LeftChild = new Node(key, value);
						node.LeftChild.Parent = node;
						break;
					}
				} while (node != null);
			}

			public bool Remove(TKey key) {
				Node node = this;
				do {
					int compare = node.Key.CompareTo(key);
					if (compare == 0) {
						if (IsLeaf) {
							RemoveChild(key);
						} else {
							node.Value = default(TValue);
						}
						return true;
					}
					if (compare < 0) {
						if (node.RightChild == null) {
							return false;
						}
						node = node.RightChild;
					} else {
						if (node.LeftChild == null) {
							return false;
						}
						node = node.LeftChild;
					}
				} while (node != null);
				return false;
			}

			public override string ToString() {
				return string.Format("{0}, {1}", Key, Value);
			}
		}
	}
}
