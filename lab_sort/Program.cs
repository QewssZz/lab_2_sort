using System;
using System.Collections;
using System.Linq;
using System.Diagnostics;

namespace lab_sort
{
    class Program
    {
        public static bool checkEquality(int[] first, int[] second)
        {
            return Enumerable.SequenceEqual(first, second);
        }
        static void Main(string[] args)
        {
            try
            {
                Stopwatch timer1 = new Stopwatch();
                Stopwatch timer2 = new Stopwatch();
                Stopwatch timer3 = new Stopwatch();
                Stopwatch timer4 = new Stopwatch();

                Console.WriteLine("Input size of array:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    throw new FormatException("Negative size.");
                }
                Console.WriteLine("Input min value of array:");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input max value of array:");
                int max = Convert.ToInt32(Console.ReadLine());
                if (min < 0)
                {
                    throw new FormatException("Min value doesn`t fit for counting sort.");
                }
                if (min > max) 
                {
                    throw new FormatException("Min value can`t be more than max value.");
                }
                Random rand = new Random();
                int[] array = new int[n];
                int[] array1 = new int[n];
                int[] array2 = new int[n];
                int[] b = new int[n];
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = rand.Next(min, max + 1);
                    array1[i] = array[i];
                    array2[i] = array[i];
                }

                for (int i = 0; i < n; i++)// copy of original array
                {
                    arr[i] = array[i];
                }
                Console.WriteLine("Array before sorting: ");
                for (int i = 0; i < n; i++)// array before sorting
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine("\n");

                //standart sort
                timer1.Start();
                Array.Sort(arr);
                timer1.Stop();
                Console.WriteLine("Array sorted by standart method: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\nStandart sort time: " + timer1.Elapsed);
                Console.WriteLine("\n");

                //bubble sort
                BubbleSort bubble = new BubbleSort();
                timer2.Start();
                bubble.bubbleSort(array);
                timer2.Stop();
                Console.WriteLine("Array sorted by bubble method: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine("\nBubble sort time: " + timer2.Elapsed);
                if (checkEquality(arr, array))
                {
                    Console.WriteLine("Array are equal to standart sorting");
                }
                else
                {
                    Console.WriteLine("Array are not equal to standart sorting");
                }
                Console.WriteLine("\n");

                //heap sort
                HeapSort heap = new HeapSort();
                timer3.Start();
                heap.Heapsort(array1);
                timer3.Stop();
                Console.WriteLine("Array sorted by heap method: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array1[i] + " ");
                }
                Console.WriteLine("\nHeap sort time: " + timer3.Elapsed);
                if (checkEquality(arr, array1))
                {
                    Console.WriteLine("Array are equal to standart sorting");
                }
                else
                {
                    Console.WriteLine("Array are not equal to standart sorting");
                }
                Console.WriteLine("\n");

                //counting sort
                CountingSort count = new CountingSort();
                timer4.Start();
                count.Counting_Sort(array2, b, max + 1);
                timer4.Stop();
                Console.WriteLine("Array sorted by counting method: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(b[i] + " ");
                }
                Console.WriteLine("\nCounting sort time: " + timer4.Elapsed);
                if (checkEquality(arr, b))
                {
                    Console.WriteLine("Array are equal to standart sorting");
                }
                else
                {
                    Console.WriteLine("Array are not equal to standart sorting");
                }
                Console.WriteLine();


            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exeption: {0}", ex.Message);
            }            
        }
    }
}
