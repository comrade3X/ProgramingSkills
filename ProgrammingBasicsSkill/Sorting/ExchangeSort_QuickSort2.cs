using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{
    using Support;

    public class ExchangeSort_QuickSort2 : Support
    {
        //Show all memeber of array
        public static void DisplayArray<T>(T[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.WriteLine("]");
        }

        public static int Partition(int[] array, int left, int right, int pivot)
        {
            int leftPoint = left - 1;
            int rightPoint = right;

            while (true)
            {
                while (array[++leftPoint] < pivot)
                {
                    //do anything
                }
                while (rightPoint > 0 && array[--rightPoint] > pivot)
                {

                }
                if (leftPoint >= rightPoint)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Item swapped: {0} to {1}", array[leftPoint], array[rightPoint]);
                    Swap<int>(array[leftPoint], array[rightPoint], x => array[leftPoint] = x, y => array[rightPoint] = y);
                }
            }

            Console.WriteLine("Pivot swapped: {0} to {1}", array[leftPoint], array[right]);
            Swap<int>(array[leftPoint], array[right], x => array[leftPoint] = x, y => array[right] = y);
            Console.Write("Update array: ");
            DisplayArray<int>(array);

            return leftPoint;
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            DisplayArray<int>(array);
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = array[right];
                int partitionPoint = Partition(array,left, right, pivot);
                QuickSort(array, left, partitionPoint - 1);
                QuickSort(array, partitionPoint + 1, right);
            }
        }

    }
}
