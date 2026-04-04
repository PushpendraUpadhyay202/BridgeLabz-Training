using System;
using System.Collections.Generic;

class ReverseList{
	static void Main(string[] args){
		List<int> list = new List<int>(new int[] {1, 2, 3, 4, 5, 6});
		LinkedList<int> linkedList = new LinkedList<int>(new int[] {1, 2, 3, 4, 5, 6});
		Console.Write("\nList (before reversing): ");
		Print(list);
		Console.Write("\nLinked List (before reversing): ");
		Print(linkedList);

		ReverseArrayList(list);
		Console.Write("\nList (after reversing): ");
		Print(list);

		ReverseLinkedList(linkedList);
		Console.Write("\nLinked List (after reversing): ");
		Print(linkedList);
	}

	static void Print(IEnumerable<int> list){
		foreach(int el in list){
			Console.Write(el + " ");
		}
		Console.WriteLine("\n");
	}

	static void ReverseArrayList(List<int> list)
	{
		int start = 0;
		int end = list.Count - 1;

		while(start < end)
		{
			int temp = list[start];
			list[start] = list[end];
			list[end] = temp;
			start++;
			end--;
		}
	}

	static void ReverseLinkedList(LinkedList<int> linkedList)
	{
		int n = linkedList.Count;
		if(n <= 1) return;

		// LinkedListNode to point to the current node while traversing in the original
		// linked list from tail to head.
		LinkedListNode<int> current = linkedList.Last;

		// temporary linked list to hold the reversed linked list.
		LinkedList<int> reversedLinkedList = new LinkedList<int>();

		// building temporary linked list which is reversed
		while(current != null)
		{
			reversedLinkedList.AddLast(current.Value);
			current = current.Previous;
		}

		// emptying our original linked list
		linkedList.Clear();

		// copying temporary linked list nodes in our original linked list
		foreach(int el in reversedLinkedList)
		{
			linkedList.AddLast(el);
		}
	}
}
