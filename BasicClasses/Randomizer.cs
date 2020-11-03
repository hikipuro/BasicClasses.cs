using System;
using System.Collections.Generic;

namespace BasicClasses {
	public class Randomizer {
		public static void Shuffle<T>(IList<T> list) {
			if (list == null) {
				return;
			}
			Random random = new Random();
			int length = list.Count;
			for (int i = 0; i < length; i++) {
				int index = random.Next(length);
				T temp = list[i];
				list[i] = list[index];
				list[index] = temp;
			}
		}
	}
}
