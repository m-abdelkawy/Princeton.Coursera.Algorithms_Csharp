using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Shuffle
    {
        public static void ShuffleSort<T>(T[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                Random r = new Random();
                int rInt = r.Next(0, i + 1);
                Helper.Exchange(ref a[rInt], ref a[i]);
            }
        }
    }
}
