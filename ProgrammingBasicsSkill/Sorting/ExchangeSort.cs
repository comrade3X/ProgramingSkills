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
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(20);
            }          

            //Duyet ca mang
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //Tim va dua 1 phan tu len vi tri cao nhat.
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap<int>(arr[j], arr[j - 1], x => arr[j] = x, y => arr[j - 1] = y);
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
