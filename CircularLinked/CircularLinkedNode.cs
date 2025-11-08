using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PII2025Listas.CircularLinked
{
	internal class CircularLinkedNode<T>
	{
		public T Data; 
		public CircularLinkedNode<T>? Next; 
		public CircularLinkedNode(T d) { 
			Data = d; 
		}
	}
}
