using System;
using System.Collections.Generic;

namespace BasicClasses {
	public class BinaryTreeNode<TKey, TValue> where TKey : IComparable<TKey> {
		public readonly TKey Key;
		public TValue Value;
		public BinaryTreeNode<TKey, TValue> LeftChild;
		public BinaryTreeNode<TKey, TValue> RightChild;

		public BinaryTreeNode(TKey key, TValue value) {
			Key = key;
			Value = value;
		}

		public void Traverse(Func<BinaryTreeNode<TKey, TValue>, bool> callback) {
			if (callback == null) {
				throw new ArgumentNullException("callback");
			}
			Queue<BinaryTreeNode<TKey, TValue>> queue =
				new Queue<BinaryTreeNode<TKey, TValue>>();
			queue.Enqueue(this);
			while (queue.Count > 0) {
				BinaryTreeNode<TKey, TValue> node = queue.Dequeue();
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

		public TValue Search(TKey key) {
			BinaryTreeNode<TKey, TValue> node = this;
			while (node != null) {
				int compare = node.Key.CompareTo(key);
				if (compare == 0) {
					return node.Value;
				}
				if (compare < 0) {
					node = node.RightChild;
				} else {
					node = node.LeftChild;
				}
			}
			return default(TValue);
		}

		public void Insert(TKey key, TValue value) {
			BinaryTreeNode<TKey, TValue> node = this;
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
					node.RightChild = new BinaryTreeNode<TKey, TValue>(key, value);
					break;
				} else {
					if (node.LeftChild != null) {
						node = node.LeftChild;
						continue;
					}
					node.LeftChild = new BinaryTreeNode<TKey, TValue>(key, value);
					break;
				}
			}
		}

		public override string ToString() {
			return string.Format("{0}, {1}", Key, Value);
		}
	}
}
