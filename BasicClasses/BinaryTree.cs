using System;
using System.Collections.Generic;

namespace BasicClasses {
	[Serializable]
	public class BinaryTree<TKey, TValue> where TKey: IComparable<TKey> {
		public Node<TKey, TValue> Root;

		public TValue this[TKey key] {
			get {
				if (Root == null) {
					return default(TValue);
				}
				Node<TKey, TValue> node = Root.Search(key);
				if (node == null) {
					return default(TValue);
				}
				return node.Value;
			}
			set {
				if (Root == null) {
					Root = new Node<TKey, TValue>(key, value);
					return;
				}
				Root.Add(key, value);
			}
		}

		public BinaryTree() {
		}

		public void Traverse(Func<Node<TKey, TValue>, bool> callback) {
			if (Root == null) {
				return;
			}
			Root.Traverse(callback);
		}

		public Node<TKey, TValue> Search(TKey key) {
			if (Root == null) {
				return null;
			}
			return Root.Search(key);
		}

		public void Add(TKey key, TValue value) {
			if (Root == null) {
				Root = new Node<TKey, TValue>(key, value);
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

#pragma warning disable CS0693
		[Serializable]
		public class Node<TKey, TValue> where TKey : IComparable<TKey> {
			public readonly TKey Key;
			public TValue Value;
			public Node<TKey, TValue> Parent;
			public Node<TKey, TValue> LeftChild;
			public Node<TKey, TValue> RightChild;

			public bool IsLeaf {
				get { return LeftChild == null && RightChild == null; }
			}

			public Node(TKey key, TValue value) {
				Key = key;
				Value = value;
			}

			public Node<TKey, TValue> RemoveChild(TKey key) {
				int compare = Key.CompareTo(key);
				if (compare == 0) {
					return null;
				}
				if (compare < 0) {
					if (RightChild == null) {
						return null;
					}
					if (RightChild.Key.CompareTo(key) == 0) {
						Node<TKey, TValue> node = RightChild;
						RightChild = null;
						return node;
					}
				} else {
					if (LeftChild == null) {
						return null;
					}
					if (LeftChild.Key.CompareTo(key) == 0) {
						Node<TKey, TValue> node = LeftChild;
						LeftChild = null;
						return node;
					}
				}
				return null;
			}

			public void Traverse(Func<Node<TKey, TValue>, bool> callback) {
				if (callback == null) {
					throw new ArgumentNullException("callback");
				}
				Queue<Node<TKey, TValue>> queue =
					new Queue<Node<TKey, TValue>>();
				queue.Enqueue(this);
				while (queue.Count > 0) {
					Node<TKey, TValue> node = queue.Dequeue();
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

			public Node<TKey, TValue> Search(TKey key) {
				Node<TKey, TValue> node = this;
				while (node != null) {
					int compare = node.Key.CompareTo(key);
					if (compare == 0) {
						return node;
					}
					if (compare < 0) {
						node = node.RightChild;
					} else {
						node = node.LeftChild;
					}
				}
				return null;
			}

			public void Add(TKey key, TValue value) {
				Node<TKey, TValue> node = this;
				while (node != null) {
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
						node.RightChild = new Node<TKey, TValue>(key, value);
						node.RightChild.Parent = node;
						break;
					} else {
						if (node.LeftChild != null) {
							node = node.LeftChild;
							continue;
						}
						node.LeftChild = new Node<TKey, TValue>(key, value);
						node.LeftChild.Parent = node;
						break;
					}
				}
			}

			public bool Remove(TKey key) {
				Node<TKey, TValue> node = this;
				while (node != null) {
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
				}
				return false;
			}

			public override string ToString() {
				return string.Format("{0}, {1}", Key, Value);
			}
		}
#pragma warning restore CS0693
	}
}
