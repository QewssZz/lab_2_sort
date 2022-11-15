using System;
using System.Collections.Generic;
using System.Text;

namespace lab_sort
{
    class HeapSort
    {
        public void Heapsort(int[] arr)
        {
            //Build_Max_heap
            int N = arr.Length;
            for (int i = N / 2 - 1; i >= 0; i--)
            {
                Max_Heapify(arr, N, i);
            }

            //Heapsort
            for (int i = N - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Max_Heapify(arr, i, 0);
            }
        }

        
        public void Max_Heapify(int[] arr, int N, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

            if (l < N && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < N && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Max_Heapify(arr, N, largest);
            }
        }
    }
}
