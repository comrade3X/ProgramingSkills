using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack: Last in First out (LIFO)
            //Collection, Enumerable
            Stack<int> stack = new Stack<int>();

            // Dua phan tu vao stack
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("So phan tu cua stack: {0}",stack.Count);

            //In ra man hinh cac phan tu cua stack (dont remove)
            foreach (var item in stack)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("So phan tu cua stack: {0}", stack.Count);


            //Xuat ra cac phan tu cua stack su dung method pop() (remove after pop)
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine("So phan tu cua stack sau khi xuat ra(pop): {0}", stack.Count);
            
            Console.ReadLine();
        }
    }
}
