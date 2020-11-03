using System;

namespace BasicClasses {
	[Serializable]
	public class TrieTree<T> {
		public delegate bool TraverseCallback(TrieNode<T> node);

		public readonly TrieNode<T> Root;

		public TrieTree() {
			Root = new TrieNode<T>(null);
		}

		public void Traverse(TraverseCallback callback) {
			if (callback == null) {
				throw new ArgumentNullException("callback");
			}
			Root.Traverse(callback);
		}

		public TrieNode<T> Search(string word) {
			return Root.Search(word);
		}

		public bool Insert(string word, T value) {
			return Root.Insert(word, value);
		}
	}
}
