using System;
using System.Collections.Generic;
using System.Text;

namespace lab_sort
{
    class CountingSort
    {
        public void Counting_Sort(int[] A, int[] B, int k) 
        {
            int[] C = new int[k];
            for (int i = 0; i < k; i++) 
            {
                C[i] = 0; 
            }
            for (int j = 0; j < A.Length; j++) 
            {
                C[A[j]]++;
            }
            for (int i = 1; i < k; i++) 
            {
                C[i] = C[i] + C[i - 1];
            }
            for (int j = A.Length - 1; j >= 0; j--) 
            {
                B[C[A[j]] - 1] = A[j];
                C[A[j]] = C[A[j]] - 1;
            }
        }
    }
}
