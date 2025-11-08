using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PII2025Listas.Listas
{
	public sealed class SinglyLinkedList<T>
	{
		private SinglyLinkedNode<T>? head, tail;
		public int Count { get; private set; }
		public bool IsEmpty => head is null;

		public void AddFirst(T item)
		{
			var n = new SinglyLinkedNode<T>(item);
			n.Next = head;
			head = n;
			if (tail is null) tail = n;
			Count++;
		}

		public void AddLast(T item)
		{
			var n = new SinglyLinkedNode<T>(item);
			if (tail is null) { 
				head = tail = n; 
			}
			else { 
				tail.Next = n; 
				tail = n; 
			}
			Count++;
		}

		public T RemoveFirst()
		{
			if (head is null) throw new InvalidOperationException("Vacía");
			var v = head.Data;
			head = head.Next;
			if (head is null) tail = null;
			Count--;
			return v;
		}

		public bool Remove(T item, IEqualityComparer<T>? cmp = null)
		{
			cmp ??= EqualityComparer<T>.Default;
			SinglyLinkedNode<T>? prev = null, cur = head;
			while (cur is not null)
			{
				if (cmp.Equals(cur.Data, item))
				{
					if (prev is null) head = cur.Next;
					else prev.Next = cur.Next;
					if (cur == tail) tail = prev;
					Count--;
					return true;
				}
				prev = cur; cur = cur.Next;
			}
			return false;
		}

		public void Reverse()
		{
			SinglyLinkedNode<T>? prev = null, cur = head;
			tail = head;
			while (cur is not null)
			{
				var nxt = cur.Next;
				cur.Next = prev;
				prev = cur;
				cur = nxt;
			}
			head = prev;
		}
		public string Dump()
		{
			var sb = new System.Text.StringBuilder();
			sb.Append('[');
			for (var c = head; c is not null; c = c.Next)
			{
				sb.Append(c.Data);
				if (c.Next is not null) sb.Append(", ");
			}
			sb.Append(']');
			return sb.ToString();
		}
	}
}
