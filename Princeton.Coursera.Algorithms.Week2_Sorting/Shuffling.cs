using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Shuffling
    {
        // For iteration i generate r(random int between 0 and i) 
        // Swap a[r] and a[i]
        public static void Shuffle<T>(T[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                Random r = new Random();
                int rInt = r.Next(0, i+1);
                Helper.Exchange(ref a[rInt], ref a[i]);
            }
        }
    }
}
