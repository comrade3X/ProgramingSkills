using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue:First in First out (FIFO)
            //Collection, Enumerable
            //Cac tinh chat con lai tuong tu Stack
            Queue<int> queue = new Queue<int>(3);
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            //In ra phan tu dau tien cua Queue (ko xoa)
            Console.WriteLine(queue.Peek());

            //xoa toan bo phan tu cua Queue
            //queue.Clear();

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }   
            Console.WriteLine("So phan tu cua Queue sau khi Dequeue: {0}", queue.Count);
          
            Console.ReadLine();
        }
    }
}
