using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Order
    {

        public int Minimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];

                }

            }
            return min;

        }
        // return ith smallest number
        public int RandomizedSelect(int[] array, int p, int r, int i)
        {
            Sort s = new Sort();
            if (p == r)
            {
                return array[p];
            }

            int q = s.Partition(ref array, p, r);
            int k = q-p + 1;
            if (i == k)
            {
                return array[q];
            }
            else if (i < k)
            {
               return RandomizedSelect(array, p, q - 1, i);
            }
            else
            {
               return RandomizedSelect(array, q + 1, r, i - k);
            }

          
        }


    }
}
