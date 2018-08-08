using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Node
    {
        public Node Next;
        public object Value;

    }

    public class Node<T> where T : class

    {
        public Node<T> Next;
        public T Value;
    }

    
}
