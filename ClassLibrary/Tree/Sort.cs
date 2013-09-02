using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sort
    {
        //switch two element in the array
        private void MySwitch(ref int[] array, int first, int second)
        {
            if ((array.Length > 0) && (array.Length >= first) && (array.Length >= second))
            {
                int temp = array[first];
                array[first] = array[second];
                array[second] = temp;

            }
        }

        public void BubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)

                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }

            }

        }

        


        public void InsertSort(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int index = i;
                while ((index > 0))
                {
                    // swithc the two word 
                    if (array[index - 1] > array[index])
                    {

                        MySwitch(ref array, index - 1, index);

                    }
                    index--;

                }


            }
        }

        private void Merge(ref int[] array, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int i;

            int[] l1 = new int[n1];
            int[] r1 = new int[n2];



            for (i = 0; i < n1; i++)
            {
                l1[i] = array[p + i];
            }

            for (i = 0; i < n2; i++)
            {
                r1[i] = array[q + i + 1];
            }

            i = 0;
            int j = 0;

            for (int k = p; k <= r; k++)
            {

                if (i >= l1.Length)
                {

                    array[k] = r1[j];
                    j++;
                }
                else if (j >= r1.Length)
                {

                    array[k] = l1[i];
                    i++;
                }
                
                else if (l1[i] <= r1[j])
                    {
                        array[k] = l1[i];
                        i++;
                        
                    
                    } else
                    {

                        array[k] = r1[j];
                        j++;

                       
                    }
                


            }
        }

        public void MergeSort(ref int[] array, int p, int r)
        {
            if (p < r)
            { 
              int q = (int)Math.Floor((double)(r+p)/2);
              MergeSort(ref array, p, q );
              MergeSort(ref array, q + 1, r);
              Merge(ref array, p, q, r);
            
            }
        
        }

        public void SelectSort(ref int[] array)
        {
            int min_index;


            for (int i = 0; i < array.Length; i++)
            {
                /* assume the min is the first element */
                min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_index])
                    {
                        min_index = j;
                    }


                }

                if (min_index != i)
                {
                    MySwitch(ref array, min_index, i);

                }
            }

        }

        /*not work*/
        public void NewSelectSort(ref int[] array)
        {
            int max_index;


            for (int i = 1; i < array.Length; i++)
            {
                /* assume the min is the first element */
                max_index = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > array[max_index])
                    {
                        max_index = j;
                    }


                }

                if (max_index != i)
                {
                    MySwitch(ref array, max_index, i);

                }
            }

        }

       public int Partition(ref int[] array, int p, int r)
        {
            int x = array[r];
            int i = p - 1;
            for (int j = p; j < r ; j++)
            {
                if (array[j] <= x)
                { 
                    i = i+1;
                    MySwitch(ref array, i, j);
                }

            }

            MySwitch(ref array,i + 1, r);
            return i + 1;
            
        }

        public void CountingSort(int[] a,ref int[] b,int k )
        {
            int[] c = new int[k];
            for (int i = 0; i < a.Length; i++)
            {
                c[a[i]] = c[a[i]] + 1;
            }

            for (int i = 1; i < k; i++)
            {
                c[i] = c[i] + c[i - 1];
            }

            for (int j = a.Length -1;j >=0; j--)
            {
                b[ c[a[j]] -1]  = a[j];
                c[a[j]] = c[a[j]] - 1;
            }
        
        }


    }
}
