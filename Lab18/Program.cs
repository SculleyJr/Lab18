using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        private static readonly List<string> Classmates = new List<string>()
        {
            "Rabin",
            "Aquoinette",
            "Chris",
            "Sean A",
            "Sean S",
            "Ross",
            "Dr. Clark",
            "Mike",
            "Catherine",
            "Bradley",
            "Jacob"
        };

        static void Main(string[] args)
        {
            var genericLinkedList = new LinkedList<string>();
            

            foreach (var student in Classmates)
            {
                genericLinkedList.AddAtStart(student);
               
                


            }
            genericLinkedList.PrintAllNodes();
           
            Console.WriteLine("");
            Console.WriteLine("which index to remove?");
            int x = int.Parse(Console.ReadLine());

            genericLinkedList.RemoveAtIndex(x);
            genericLinkedList.PrintAllNodes();
            Console.WriteLine("which index to add");
            int y = int.Parse(Console.ReadLine());
            int z = y - 1;
            genericLinkedList.InsertAtIndex(z, "l");
            genericLinkedList.PrintAllNodes();
            Console.WriteLine("Linked List prineted in reverse");
            foreach (var student in Classmates)
            {
                genericLinkedList.PrintInReverse(student);

            }
            Console.WriteLine("done");
        }
    }
}
