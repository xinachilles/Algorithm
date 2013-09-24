using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Sort
    {
        class StringComparator : IComparer<string>
        {

            private String sort(String s)
            {
                char[] letters = s.ToCharArray();
                Array.Sort(letters);
                return new String(letters);
            }

            public int Compare(String s1, String s2)
            {
                return sort(s1).CompareTo(sort(s2));
            }
        }


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

        #region Merge Sort

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

                }
                else
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
                int q = (int)Math.Floor((double)(r + p) / 2);
                MergeSort(ref array, p, q);
                MergeSort(ref array, q + 1, r);
                Merge(ref array, p, q, r);

            }

        }
        #endregion

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
            for (int j = p; j < r; j++)
            {
                if (array[j] <= x)
                {
                    i = i + 1;
                    MySwitch(ref array, i, j);
                }

            }

            MySwitch(ref array, i + 1, r);
            return i + 1;

        }

        public void CountingSort(int[] a, ref int[] b, int k)
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

            for (int j = a.Length - 1; j >= 0; j--)
            {
                b[c[a[j]] - 1] = a[j];
                c[a[j]] = c[a[j]] - 1;
            }

        }

        #region 11.1
        // 11.1 You are given two sorted arrays, A and B, where A has a large enough buffer at the
        //end to hold B. Write a method to merge B into A in sorted order.
        public void MergeTwoArray(int[] a, int[] b, ref int[] c)
        {
            int last_a = a.Length - 1;
            int last_b = b.Length - 1;
            int last_merage = last_a + last_b + 1;


            while (last_a >= 0 && last_b >= 0)
            {
                if (a[last_a] >= b[last_b])
                {
                    c[last_merage] = a[last_a];
                    last_merage = last_merage - 1;
                    last_a = last_a - 1;

                }
                else
                {

                    c[last_merage] = b[last_a];
                    last_merage = last_merage - 1;
                    last_b = last_b - 1;

                }
            }

            //  copy the remain item 
            while (last_b >= 0)
            {
                c[last_merage] = b[last_b];
                last_merage = last_merage - 1;
                last_b = last_b - 1;
            }

            while (last_a >= 0)
            {
                c[last_merage] = a[last_a];
                last_merage = last_merage - 1;
                last_a = last_a - 1;
            }
        }
        #endregion

        #region 11.2
        //Write a method to sort an array of strings so that all the anagrams are next to each
        //other.

        //You may notice that the algorithm above is a modification of bucket sort.

        private String sortchars(string s)
        {
            char[] content = s.ToCharArray();
            Array.Sort(content);
            return new String(content);
        }


        public void AnagramsSort(ref string[] array)
        {
            Hashtable hash = new Hashtable();

            /* Group words by anagram */
            foreach (var s in array)
            {
                String key = sortchars(s);
                if (!hash.Contains(key))
                {
                    hash.Add(key, new LinkedList<string>());
                }

                LinkedList<String> anagrams = (LinkedList<String>)hash[key];
                //LinkedList<string> anagrams = new LinkedList<string>((LinkedList<String>)hash[key]);
                anagrams.AddFirst(s);
            }

            /* Convert hash table to array */
            int index = 0;
            foreach (string key in hash.Keys)
            {
                LinkedList<String> list = (LinkedList<String>)hash[key];
                foreach (var s in list)
                {
                    array[index] = s;
                    index++;
                }


            }



        }


        public string[] AnagramsSortA(String[] arr)
        {

            if (arr == null || arr.Length == 0 || arr.Length == 1)
            { return arr; }

            Array.Sort(arr, new StringComparator());

            return arr;

        }

        #endregion


        #region 11.8
        /*
         Imagine you are reading in a stream of integers. Periodically, you wish to be able
         to look up the rank of a number x (the number of values less than or equal tox).
         Implement the data structures and algorithms to support these operations.That
         is, implement the method track(int x), which is called when each number
         is generated, and the method getRankOfNumber(int x), which returns the
         number of values less than or equal to x (not including x itself).
         
         */
        public class RankNode
        {
            public int left_size = 0;
            public RankNode left, right;
            public int data = 0;
            public RankNode(int d)
            {
                data = d;
            }

            public int getRank(int d)
            {
                if (d == data)
                {
                    return left_size;
                }
                else if (d < data)
                {
                    if (left == null) return -1;
                    else return left.getRank(d);
                }
                else
                {
                    int right_rank = right == null ? -1 : right.getRank(d);
                    if (right_rank == -1) return -1;
                    else return left_size + 1 + right_rank;
                }
            }
            public void insert(int d)
            {
                if (d <= data)
                {
                    if (left != null) left.insert(d);
                    else left = new RankNode(d);
                    left_size++;
                }
                else
                {
                    if (right != null) right.insert(d);
                    else right = new RankNode(d);
                }
            }


        }


        public class Question
        {
            private static RankNode root = null;

            public static void track(int number)
            {
                if (root == null)
                {
                    root = new RankNode(number);
                }
                else
                {
                    root.insert(number);
                }
            }
            public static int getRankOfNumber(int number)
            {
                return root.getRank(number);
            }
        }


        #endregion


    }
}









