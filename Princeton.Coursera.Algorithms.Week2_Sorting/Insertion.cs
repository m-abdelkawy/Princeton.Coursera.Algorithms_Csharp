using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Insertion
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Less(a[j], a[j - 1]))
                        Exchange(ref a[j], ref a[j - 1]);
                    else
                        break;
                }
                Console.Write($"Pass #{i}: ");
                Helper.Display(a);
                Console.WriteLine();
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
