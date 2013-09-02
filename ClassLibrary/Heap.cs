using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Heap
    {
        private void MaxHeapify(ref int[] array,int i)
        {
            int left = 2*i+1;
            int right = 2*i+2;
            int largest;

            if ((left < array.Length) && (array[left] > array[i]))
            {
                largest = left;
            }
            else {

                largest = i;
            
            }

            if ((right < array.Length) && (array[right] > array[largest]))
            {

                largest = right;
            }
            
            if (largest != i)
            {
                MySwitch(ref array,i, largest);
                MaxHeapify(ref array, largest);
            }

            

        }

      public void BuildMaxHeap(ref int[] array)
        {
            for (int i =(int)Math.Ceiling((double)array.Length/2); i >=0; i--)
			{
                MaxHeapify(ref array, i);
			}
        
        }

        private void MySwitch(ref int[] array, int first, int second)
        {
            if ((array.Length > 0) && (array.Length >= first) && (array.Length >= second))
            {
                int temp = array[first];
                array[first] = array[second];
                array[second] = temp;

            }
        }

        public void PrintResult(int[] array)
        {

            foreach (var item in array)
            {
                Console.Write(item.ToString());
            }

        }

        public void HeapSort(ref int[] array)
        {
            BuildMaxHeap(ref array);
            for (int i = array.Length -1; i >0; i--)
            {
                int[] b = new int[i];

                MySwitch(ref array, 0, i);

                for (int j = 0; j < i; j++)
                {
                    b[j] = array[j];
                }

                           
                
                MaxHeapify(ref b, 0);

                for (int j = 0; j < i; j++)
                {
                    array[j] = b[j];
                }


            }
        }

        // priority queues
        public void HeapIncreaseKey()
        {
        
        }
    
    }
}
