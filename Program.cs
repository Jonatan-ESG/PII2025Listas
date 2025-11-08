using PII2025Listas.CircularLinked;
using PII2025Listas.DoublyLinked;
using PII2025Listas.Listas;

namespace PII2025Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var sll = new SinglyLinkedList<int>();
			sll.AddFirst(2); sll.AddLast(3); sll.AddFirst(1);
			Console.WriteLine(sll.Dump());   // [1, 2, 3]
			sll.Remove(2);
			sll.Reverse();
			Console.WriteLine(sll.Dump());   // [3, 1]

			var dll = new DoublyLinkedList<string>();
			dll.AddLast("A"); dll.AddLast("B"); dll.AddLast("C");
			Console.WriteLine(dll.DumpForward());  // [A, B, C]
			Console.WriteLine(dll.DumpBackward()); // [C, B, A]
			dll.Remove(x => x == "B");
			Console.WriteLine(dll.DumpForward());  // [A, C]

			var cll = new CircularLinkedList<char>();
			foreach (var ch in new[] { 'X', 'Y', 'Z' }) cll.AddLast(ch);
			Console.WriteLine(cll.DumpOnce());     // [X, Y, Z]
			Console.WriteLine(cll.RemoveFirst());  // X
			Console.WriteLine(cll.DumpOnce());     // [Y, Z]

		}
	}
}
