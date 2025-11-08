using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PII2025Listas.Listas
{
	public sealed class SinglyLinkedNode<T>
	{
		public T Data; 
		public SinglyLinkedNode<T>? Next; 
		public SinglyLinkedNode(T d) { 
			Data = d; 
		}
	}
}
