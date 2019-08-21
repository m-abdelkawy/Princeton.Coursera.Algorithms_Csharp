using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public static class Helper
    {
        internal static void Display<T>(T[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + "\t");
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

        public static void TestClientSelectionSort()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("   Selection Sort Test Client (Generic Version):");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter size of the Array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element No.{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();

            Console.WriteLine("During Sorting: ");
            Selection.Sort(arr);
            Console.WriteLine();

            Console.WriteLine("After Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();
        }


        public static void TestClientInsertionSort()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("   Insertion Sort Test Client (Generic Version):");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter size of the Array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element No.{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();

            Console.WriteLine("During Sorting: ");
            Insertion.Sort(arr);
            Console.WriteLine();

            Console.WriteLine("After Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();
        }

        public static void TestClientShellSort()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("   Shell Sort Test Client (Generic Version):");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter size of the Array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element No.{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting: ");
            Console.Write("0 - Sort: ");
            Helper.Display(arr);
            Console.WriteLine();

            Console.WriteLine("During Sorting: ");
            Shell.Sort(arr);
            Console.WriteLine();

            Console.WriteLine("After Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();
        }

        public static void TestClientShuffleSort()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("   Shuffle Sort Test Client (Generic Version):");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter size of the Array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element No.{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();

            Console.WriteLine("During Sorting: ");
            Shuffling.Shuffle(arr);
            Console.WriteLine();

            Console.WriteLine("After Sorting: ");
            Helper.Display(arr);
            Console.WriteLine();
        }



    }
}
