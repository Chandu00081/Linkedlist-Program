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
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(32);
            linkedList.Add(54);
            linkedList.Add(76);
            linkedList.Add(211);
            linkedList.Display();


        }
    }
}
