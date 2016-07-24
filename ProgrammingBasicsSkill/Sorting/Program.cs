using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    using Support;
    public class Program : Support
    {
        /// <summary>
        /// INTRO:
        /// 
        /// Các giải thuật sắp xếp trên dãy/mảng:
        /// *, Săp xếp bằng phương pháp đếm (couting sort)
        /// 
        /// *, Săp xếp bằng phương pháp đổi chỗ (exchange sort)
        ///     - sắp xếp nổi bọt (bubble sort)
        ///     - sắp xếp lắc( shaker sort)
        ///     - giảm độ tăng hay độ dài bước giảm dần (shell sort)
        ///     - sắp xếp dựa trên sự phân hoạch (quick sort)
        ///     
        /// *, Săp xếp bằng phương pháp chọn lựa (selection sort)
        /// 
        /// *, Săp xếp bằng phương pháp chèn (inserting sort)
        /// 
        /// *, Săp xếp bằng phương pháp trộn (merge sort)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            ExchangeSort.BubbleSort();
            Console.ReadLine();
        }
    }
}
