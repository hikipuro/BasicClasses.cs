using System;

namespace BasicClasses {
	[Serializable]
	public class TrieTree<T> {
		public readonly TrieTreeNode<T> Root;

		public TrieTree() {
			Root = new TrieTreeNode<T>(null);
		}

		public void Traverse(Func<TrieTreeNode<T>, bool> callback) {
			Root.Traverse(callback);
		}

		public TrieTreeNode<T> Search(string word) {
			return Root.Search(word);
		}

		public bool Insert(string word, T value) {
			return Root.Insert(word, value);
		}
	}
}
