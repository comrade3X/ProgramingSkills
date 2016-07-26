using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using Support;
    public class ExchangeSort : Support
    {
        #region Bubble Sort


        /// <summary>
        ///  Bubble Sort
        ///  
        /// Method(Idea):
        /// 
        /// - Duyệt mảng từ cuối lên trên
        /// - Nếu phần từ ở dưới nhỏ hơn phân từ ở ngay trên thì nó sẽ được đưa lên trên ( tính chất của bọt khí, nhẹ hơn(nhỏ hơn) thì nổi lên trên)
        /// - Nó được đưa lên bằng phương pháp đổi chỗ 2 phần từ cho nhau      
        /// </summary>
        public static void BubbleSort()
        {
            var array = GenerateRamdonArray(arr);

            //Duyet ca mang
            for (int i = 0; i < array.Length - 1; i++)
            {
                //Tim va dua 1 phan tu len vi tri cao nhat.
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap<int>(array[j], array[j - 1], x => array[j] = x, y => array[j - 1] = y);
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        #endregion

        #region QuickSort

        /// <summary>
        /// Quick Sort ( Partitioning Sort)
        /// 
        /// Sắp xếp nhanh ( sắp xếp phân mảnh)
        /// 
        /// chon 1 phan tu lam moc (pivot)
        ///  - cac phan tu nam ben trai pivot thi NHO hon no
        ///  - cac phan tu nam ben phai pivot thi LON hon no
        /// </summary>
        public static void QuickSort(int[] array, int left, int right)
        {
            int pivot;
            int pivotIndex, k;
            pivotIndex = FindPivot(array, left, right);
            if (pivotIndex != -1)
            {
                pivot = array[pivotIndex];
                k = Partition(array, left, right, pivot);
                QuickSort(array, left, k - 1);
                QuickSort(array, k, right);
            }
        }

        private static int FindPivot(int[] array, int left, int right)
        {
            //khoi tao phan tu dau tien cua mang
            int firstKey;
            int k;
            k = left + 1;
            firstKey = array[left];
            while (k <= right && array[k] == firstKey)
            {
                k++;
            }
            if (k > right)
            {
                return -1;
            }
            else
            {
                if (array[k] > firstKey)
                {
                    return k;
                }
                else
                {
                    return left;
                }
            }
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            int L = left;
            int R = right;
            while (L <= R)
            {
                while (array[L] < pivot)
                {
                    L++;
                }
                while (array[R] >= pivot)
                {
                    R--;
                }
                if (L < R)
                {
                    Swap(array[L], array[R], x => array[L] = x, y => array[R] = y);
                }
            }
            return L;
        }
        #endregion
    }
}
