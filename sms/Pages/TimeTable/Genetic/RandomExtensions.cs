using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random random, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
