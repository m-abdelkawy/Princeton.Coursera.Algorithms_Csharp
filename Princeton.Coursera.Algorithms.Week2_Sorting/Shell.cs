using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Shell
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            int N = a.Length;

            // 3X-1 increment sequence
            int h = 1;
            while (h < N / 3)
            {
                h = h * 3 + 1;
            }

            // Sorting
            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h; j -= h)
                    {
                        if (Less(a[j], a[j - h]))
                        {
                            Exchange(ref a[j], ref a[j - h]);
                        }
                    }
                }
                Console.Write(h + " - Sort: ");
                Helper.Display(a);
                Console.WriteLine();

                // Next Increment
                h = h / 3;
            }
        }

        private static bool Less<T>(T i, T j) where T : IComparable<T>
        {
            return i.CompareTo(j) < 0;
        }

        private static void Exchange<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }
    }
}
