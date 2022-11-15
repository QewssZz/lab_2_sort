using System;
using System.Collections.Generic;
using System.Text;

namespace lab_sort
{
    class BubbleSort
    {
        public void bubbleSort(int[] bubble)
        {
            int tmp;
            for (int i = 1; i < bubble.Length; i++)
            {
                for (int j = bubble.Length - 1; j > i - 1; j--)
                {
                    if (bubble[j] < bubble[j - 1])
                    {
                        tmp = bubble[j - 1];
                        bubble[j - 1] = bubble[j];
                        bubble[j] = tmp;
                    }
                }
            }
        }
    }
}
