using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //LinearSearch(arr, 3);
            BinarySearch(arr, 115, 0, arr.Length);
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// Linear Search (Array A, Value X)
        /// 
        /// </summary>
        /// <Step 1> Set i to 0</Step1>
        /// <Step 2> If i > n go to Step 7</Step 2>
        /// <Step 3> If A[i]=x then go to Step 6</Step 3>
        /// <Step 4> Set i to i+1 </Step 4>
        /// <Step 5> Go to Step 2</Step 5>
        /// <Step 6> Print element X found at index i then go to Step 8</Step 6>
        /// <Step 7> Print element not found</Step 7>
        /// <Step 8> Exit </Step 8>
        static void LinearSearch(int[] arr, int input)
        {
            int i = 0;

            while (arr[i] != input && i < arr.Length)
            {
                i++;
                if (i > arr.Length)
                {
                    Console.WriteLine("Not found");
                    return;
                }
            }

            Console.WriteLine("Element {0} found at index {1}", arr[i], i);
        }

        /// <summary>
        /// 
        /// Binary Search ( T array, T input)
        /// (ap dung cho day co Values tang dan:)
        /// eg: Find By Id
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="input"></param>
        static void BinarySearch(int[] arr, int input, int first, int last)
        {           
            if (first > last)
            {
                Console.Write("Not Found");
                return;
            }

            int mid = (first + last) / 2;

            if (input == arr[mid])
            {
                Console.Write("Element {0} found at index {1}", input, mid);
                return;
            }

            if (input < arr[mid])
            {
                BinarySearch(arr, input, first, mid);
            }

            if (input > arr[mid])
            {
                BinarySearch(arr, input, mid, last);
            }   
        }
    }
}
