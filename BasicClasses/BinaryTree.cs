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
			Node node = Root.Remove(key);
			if (Root == node) {
				if (node.LeftChild == null) {
					Root = node.RightChild;
					if (Root != null) {
						Root.Parent = null;
					}
					return true;
				}
				if (node.RightChild == null) {
					Root = node.LeftChild;
					Root.Parent = null;
					return true;
				}
				Node max = node.LeftChild.GetMaxDescendant();
				if (max == null) {
					Root = node.LeftChild;
					Root.Parent = null;
					Root.RightChild = node.RightChild;
					Root.RightChild.Parent = Root;
					return true;
				}
				if (max.LeftChild != null) {
					max.Parent.RightChild = max.LeftChild;
					max.LeftChild.Parent = max.Parent;
				}
				max.LeftChild = node.LeftChild;
				max.LeftChild.Parent = max;
				max.RightChild = node.RightChild;
				max.RightChild.Parent = max;
				Root = max;
				Root.Parent = null;
			}
			return node != null;
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

			public Node GetMinDescendant() {
				if (LeftChild == null) {
					return null;
				}
				Node node = LeftChild;
				while (node.LeftChild != null) {
					node = node.LeftChild;
				}
				return node;
			}

			public Node GetMaxDescendant() {
				if (RightChild == null) {
					return null;
				}
				Node node = RightChild;
				while (node.RightChild != null) {
					node = node.RightChild;
				}
				return node;
			}

			public Node RemoveChild(TKey key) {
				if (LeftChild != null) {
					if (LeftChild.Key.CompareTo(key) == 0) {
						Node node = LeftChild;
						LeftChild.Parent = null;
						LeftChild = null;
						return node;
					}
				}
				if (RightChild != null) {
					if (RightChild.Key.CompareTo(key) == 0) {
						Node node = RightChild;
						RightChild.Parent = null;
						RightChild = null;
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
					if (compare < 0) {
						if (node.RightChild != null) {
							node = node.RightChild;
							continue;
						}
						node.RightChild = new Node(key, value);
						node.RightChild.Parent = node;
						break;
					} else if (compare > 0) {
						if (node.LeftChild != null) {
							node = node.LeftChild;
							continue;
						}
						node.LeftChild = new Node(key, value);
						node.LeftChild.Parent = node;
						break;
					}
					node.Value = value;
					break;
				} while (node != null);
			}

			public Node Remove(TKey key) {
				Node node = this;
				do {
					int compare = node.Key.CompareTo(key);
					if (compare < 0) {
						if (node.RightChild == null) {
							break;
						}
						node = node.RightChild;
						continue;
					}
					if (compare > 0) {
						if (node.LeftChild == null) {
							break;
						}
						node = node.LeftChild;
						continue;
					}

					if (node.Parent == null) {
						return node;
					}
					if (node.IsLeaf) {
						node.Parent.RemoveChild(key);
						return node;
					}

					Node parent = node.Parent;
					node.Parent = null;
					bool isLeft = parent.LeftChild == this;

					if (node.LeftChild == null) {
						if (isLeft) {
							parent.LeftChild = node.RightChild;
						} else {
							parent.RightChild = node.RightChild;
						}
						if (node.RightChild != null) {
							node.RightChild.Parent = parent;
						}
						return node;
					}
					if (node.RightChild == null) {
						if (isLeft) {
							parent.LeftChild = node.LeftChild;
						} else {
							parent.RightChild = node.LeftChild;
						}
						node.LeftChild.Parent = parent;
						return node;
					}

					Node max = node.LeftChild.GetMaxDescendant();
					if (max == null) {
						if (isLeft) {
							parent.LeftChild = node.LeftChild;
						} else {
							parent.RightChild = node.LeftChild;
						}
						node.LeftChild.Parent = parent;
						return node;
					}
					if (max.LeftChild != null) {
						max.Parent.RightChild = max.LeftChild;
						max.LeftChild.Parent = max.Parent;
					}
					max.LeftChild = node.LeftChild;
					node.LeftChild.Parent = max;
					max.RightChild = node.RightChild;
					node.RightChild.Parent = max;
					if (isLeft) {
						parent.LeftChild = max;
					} else {
						parent.RightChild = max;
					}
					max.Parent = parent;
					return node;
				} while (node != null);
				return null;
			}

			public override string ToString() {
				return string.Format("{0}, {1}", Key, Value);
			}
		}
	}
}
