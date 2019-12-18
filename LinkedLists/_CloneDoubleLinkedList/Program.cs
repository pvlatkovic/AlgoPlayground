using System;

public class Program
{
	public static void MainX()
	{
		int[] testLinkedListValues = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Node<int>[] testNodes = new Node<int>[8];

		// create test linked list
		Node<int> linkedList = new Node<int>(testLinkedListValues[0]);
		var nextNode = linkedList;
		testNodes[0] = nextNode;

		for (int i = 1; i < testLinkedListValues.Length; i++)
		{
			nextNode.Next = new Node<int>(testLinkedListValues[i]);
			testNodes[i] = nextNode.Next;
			nextNode = nextNode.Next;
		}

		for (int i = 0; i < testNodes.Length; i++)
		{
			if (i == 0)
				testNodes[0].Previous = testNodes[7];
			if (i == 1)
				testNodes[1].Previous = testNodes[0];
			if (i == 2)
				testNodes[2].Previous = testNodes[0];
			if (i == 3)
				testNodes[3].Previous = testNodes[1];
			if (i == 4)
				testNodes[4].Previous = testNodes[2];
			if (i == 5)
				testNodes[5].Previous = testNodes[4];
			if (i == 6)
				testNodes[6].Previous = testNodes[6];
		}

		// glavna metoda
		var clone = CloneDoubleLinkedList(linkedList);
		if (clone != null)
		{
			var current = clone;
			while (current != null) // test - povecamo sve Value klona za 1 da dokazemo da su liste pravilno odvojene
			{
				current.Value += 1;
				current = current.Next;
			}

			Console.WriteLine("parent nodovi su u zagradama");
			Console.Write("Originalna lista: ");
			linkedList.Print();
			Console.WriteLine();

			Console.Write("Klonirana lista: ");
			clone.Print();
		}

		Console.ReadKey();
	}

	public static Node<int> CloneDoubleLinkedList(Node<int> linkedList)
	{
		var current = linkedList;

		// redom insertovati clonirane nodove posle svakog originalnog noda
		while (current != null)
		{
			var cloneCurrent = new Node<int>(current.Value);
			// prevezivanje - cloneCurrent.Next u current.Next i current to cloneCurrent
			cloneCurrent.Next = current.Next;
			current.Next = cloneCurrent;

			current = cloneCurrent.Next;
		}

		// povezivanje previous clonova
		current = linkedList;
		while (current != null)
		{
			if (current.Previous != null)
			{
				var cloneOfThePrevious = current.Previous.Next;
				var cloneOfTheCurrent = current.Next;
				if (cloneOfTheCurrent != null)
					cloneOfTheCurrent.Previous = cloneOfThePrevious;

				current = cloneOfTheCurrent.Next;
			}
			else
			{
				current = current.Next.Next;
			}
		}

		// razdvajanje dve liste
		current = linkedList;
		Node<int> clonedLinkedList = linkedList.Next;
		var currentCloned = clonedLinkedList;
		while (current != null)
		{
			if (currentCloned != null)
			{
				current.Next = currentCloned.Next; // vracamo vezu izmedju originalnih nodova
				currentCloned.Next = current.Next.Next;

				if (currentCloned.Next != null)
					currentCloned = currentCloned.Next.Next;
			}

			current = current.Next;
		}

		return clonedLinkedList;
	}

	// data structure definition
	public class Node<T>
	{
		public T Value { get; set; }
		public Node<T> Next { get; set; }
		public Node<T> Previous { get; set; }

		public Node(T value)
		{
			Value = value;
			Next = null;
			Previous = null;
		}

		public void Print()
		{
			var node = this;
			while (node != null)
			{
				Console.Write(node.Value + (node.Previous != null ? $" ({node.Previous.Value}), " : ", "));
				node = node.Next;
			}
		}
	}
}