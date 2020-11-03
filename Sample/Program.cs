﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BasicClasses;

namespace Sample {
	class MainClass {
		public static void Main(string[] args) {
			Console.WriteLine("Hello World!");
			TestXorshift32();
			TestXorshift128Plus();
			//TestRandomizer();
			//TestBinaryTree();
			//TestTrieTree();
		}

		public static double Benchmark(Action action, int count) {
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				action();
			}
			stopwatch.Stop();
			return stopwatch.Elapsed.TotalMilliseconds;
		}

		public static T TestSerialize<T>(T value) {
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new MemoryStream();
			formatter.Serialize(stream, value);
			stream.Position = 0;
			value = (T)formatter.Deserialize(stream);
			stream.Close();
			return value;
		}

		public static void TestXorshift32() {
			Random random = new Random();
			double time = Benchmark(() => {
				random.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);

			Xorshift32 xorshift = new Xorshift32();
			time = Benchmark(() => {
				xorshift.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);
		}

		public static void TestXorshift128Plus() {
			Random random = new Random();
			double time = Benchmark(() => {
				random.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);

			Xorshift128Plus xorshift = new Xorshift128Plus();
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(xorshift.Next());
			}
			time = Benchmark(() => {
				xorshift.Next();
			}, 100000);
			Console.WriteLine("time: {0}", time);
		}

		public static void TestRandomizer() {
			int[] array = new int[10];
			for (int i = 0; i < array.Length; i++) {
				array[i] = i;
			}
			Randomizer.Shuffle(array);
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
			Console.WriteLine();
			List<int> list = new List<int>();
			for (int i = 0; i < 10; i++) {
				list.Add(i);
			}
			Randomizer.Shuffle(list);
			for (int i = 0; i < list.Count; i++) {
				Console.WriteLine(list[i]);
			}
		}

		public static void TestBinaryTree() {
			BinaryTree<int, int> tree = new BinaryTree<int, int>();
			tree.Insert(123, 123);
			tree.Insert(21, 21);
			tree.Insert(54, 54);
			tree.Insert(74, 74);
			tree.Insert(32, 32);

			tree = TestSerialize(tree);

			Console.WriteLine(tree.Search(21));
			Console.WriteLine(tree.Search(11));
			Console.WriteLine(tree.Search(74));
			tree.Traverse((node) => {
				Console.WriteLine(node);
				return true;
			});
		}

		public static void TestTrieTree() {
			TrieTree<string> tree = new TrieTree<string>();
			tree.Insert("a", "test a");
			tree.Insert("ab", "test ab");
			tree.Insert("abc", "test abc");
			tree.Insert("bc", "test bc");
			tree.Insert("cdef", "test cdef");

			Console.WriteLine(tree.Search("a"));
			Console.WriteLine(tree.Search("abc"));
			Console.WriteLine(tree.Search("c"));
			Console.WriteLine(tree.Search("cde"));
			Console.WriteLine(tree.Search("cdef"));
		}
	}
}
