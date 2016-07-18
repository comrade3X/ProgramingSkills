using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack: Last in First out (LIFO)
            //Collection, Enumerable
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
