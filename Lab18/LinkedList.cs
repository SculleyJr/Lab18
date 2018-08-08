using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }

        public Node<T> Head;
        public Node<T> Current;

        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value       
            };

            newNode.Next = Head.Next;
            Head.Next = newNode;
            Count++;
        }

        public void AddToEnd(T value)
        {
            var newNode = new Node<T>();
            newNode.Value = value;
            Current.Next = newNode;
            Current = newNode;
            Count++;

        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            Count--;
        }

        public Boolean RemoveAtIndex(int x)
        {
            if (x > Count)
            {
                Console.WriteLine("not valid");
                return false;
            }
                int y = 0;
                Node<T> curr = Head;
                while (curr.Next != null)
                {
                    y++;
                    curr = curr.Next;
                    if (y == x - 1)
                    {
                        curr.Next = curr.Next.Next;
                        break;
                    }
                }
            return true;
        }
        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }


        public Boolean InsertAtIndex(int x, T value)
        {
            if (x > Count)
            {
                Console.WriteLine("not valid");
                return false;
            }
            Node<T> curr = Head;
            int y = 0;
            while (curr.Next != null)
            {
                y++;
                curr = curr.Next;
                if (y == x)
                {
                    var temp = new Node<T>()
                    {
                        Value = value
                    };

                    temp.Next = curr.Next;
                    curr.Next = temp;
                }

            }
        
            return true;
        }

        
        public void PrintReverse()
        {
            Node<T> next = Head;
            Node<T> afterNext;
            Node<T> currHead = Head.Next;

          

        }  
    }
}
