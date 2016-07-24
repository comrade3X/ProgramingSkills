using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    public class Support
    {
        #region Support    
        public static void Swap<T>(T a, T b, Action<T> setA, Action<T> setB)
        {
            T temp = a;
            setA(b);
            setB(temp);
        }

        public static int[] arr = new int[20];

        public static int[] GenerateRamdonArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(20);
            }
            return arr;
        }
        #endregion
    }
}

