using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Selection
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (Less(arr[j], arr[min]))
                    {
                        min = j;
                    }
                }
                if (min != i)
                    Exchange(ref arr[i], ref arr[min]);
                Helper.Display(arr);
                Console.WriteLine();
            }
        }

        public static bool Less<T>(T item1, T item2) where T : IComparable<T>
        {
            return item1.CompareTo(item2) < 0;
        }
        
        public static void Exchange<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
