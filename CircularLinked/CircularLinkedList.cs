using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025Listas.CircularLinked
{
	public sealed class CircularLinkedList<T>
	{
		private CircularLinkedNode<T>? tail;
		public int Count { get; private set; }
		public bool IsEmpty => tail is null;

		public void AddLast(T item)
		{
			var n = new CircularLinkedNode<T>(item);
			if (tail is null) { tail = n; tail.Next = tail; }
			else { n.Next = tail.Next; tail.Next = n; tail = n; }
			Count++;
		}

		public T RemoveFirst()
		{
			if (tail is null) throw new InvalidOperationException("Vacía");
			var head = tail.Next!;
			var v = head.Data;
			if (head == tail) tail = null;
			else tail.Next = head.Next;
			Count--;
			return v;
		}

		public string DumpOnce()
		{
			if (tail is null) return "[]";
			var sb = new System.Text.StringBuilder().Append('[');
			var head = tail.Next!;
			var c = head;
			do { sb.Append(c.Data); c = c.Next!; if (c != head) sb.Append(", "); } while (c != head);
			return sb.Append(']').ToString();
		}
	}

}
