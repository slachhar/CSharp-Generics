using System;
using System.Collections.Generic;

namespace Generics
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			////Array
			//String[] array = new String[3];
			//Array.Resize(ref array, 5);

			////List
			//List<String> list = new List<string>();
			//while (list.Count < 10)
			//{
			//	list.Add("1");
			//	Console.WriteLine(list.Capacity);
			//}

			////Queue
			//Queue<int> queue = new Queue<int>();
			//queue.Enqueue(1);
			//queue.Enqueue(2);
			//queue.Enqueue(3);

			//var first = queue.Dequeue(); // it will return and remove the items from first come first serve bases

			//var peek = queue.Peek(); // it return the first item in the queue

			//bool present = queue.Contains(5); // it will return if the queue contains the paramter passed

			//var array1 = queue.ToArray(); // it will convert the queue to array

			////Stack
			//Stack<int> stack = new Stack<int>();
			//stack.Push(1);
			//stack.Push(2);
			//stack.Push(3);

			//var firstStack = queue.Dequeue(); // it will return and remove the items from first come first serve bases

			//var peekStack = queue.Peek(); // it return the first item in the queue

			//bool presentStack = queue.Contains(5); // it will return if the queue contains the paramter passed

			//var array1Stack = queue.ToArray(); // it will convert the queue to array

			//HashSet
			HashSet<int> hashset = new HashSet<int>();
			hashset.Add(1);
			hashset.Add(2);
			hashset.Add(2); //wont be added because it is already there

			HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
			HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
			set1.IntersectWith(set2);
			foreach (var item in set1)
			{
				Console.WriteLine(item);
			}

			set1 = new HashSet<int> { 1, 2, 3 };
			set2 = new HashSet<int> { 2, 3, 4 };
			set1.UnionWith(set2);
			foreach (var item in set1)
			{
				Console.WriteLine(item);
			}
			

			set1 = new HashSet<int> { 1, 2, 3 };
			set2 = new HashSet<int> { 2, 3, 4 };
			set1.SymmetricExceptWith(set2);
			foreach (var item in set1)
			{
				Console.WriteLine(item);
			}

			Console.Read();
		}
	}
}