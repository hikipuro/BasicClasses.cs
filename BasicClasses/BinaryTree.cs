using System;

namespace BasicClasses {
	public class BinaryTree<TKey, TValue> where TKey: IComparable<TKey> {
		public BinaryTreeNode<TKey, TValue> Root;

		public BinaryTree() {
		}

		public void Traverse(Func<BinaryTreeNode<TKey, TValue>, bool> callback) {
			if (Root == null) {
				return;
			}
			Root.Traverse(callback);
		}

		public TValue Search(TKey key) {
			if (Root == null) {
				return default(TValue);
			}
			return Root.Search(key);
		}

		public void Insert(TKey key, TValue value) {
			if (Root == null) {
				Root = new BinaryTreeNode<TKey, TValue>(key, value);
				return;
			}
			Root.Insert(key, value);
		}
	}
}
