using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkldist
{
    internal class AddList
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();

            Console.WriteLine("Add elements into Linkedlist using AddLast Method:");
            linkedList.Add(23);
            linkedList.Add(92);
            linkedList.Add(12);
            linkedList.Display();



        }
    }
}
