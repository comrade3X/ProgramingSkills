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

        /// <summary>
        /// Quick Sort ( Partitioning Sort)
        /// 
        /// Sắp xếp nhanh ( sắp xếp phân mảnh)
        /// 
        /// </summary>
        public static void QuickSort()
        {

        }
    }
}
