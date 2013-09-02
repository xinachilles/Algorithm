using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class Dynamic
    {

        public void FastestWay(int[,] a, int[,] t, int[] e, int x1, int x2, int n, ref int f_final, ref int l_final)
        {
            int[] f1 = new int[n];
            int[] f2 = new int[n];
            int[] l1 = new int[n];
            int[] l2 = new int[n];



            f1[0] = (e[0] + a[0, 0]);
            f2[0] = (e[1] + a[1, 0]);

            for (int i = 1; i < n; i++)
            {
                if (f1[i - 1] + a[0, i] <= f2[i - 1] + a[0, i] + t[1, i - 1])
                {
                    f1[i] = (f1[i - 1] + a[0, i]);
                    l1[i] = (1);
                }
                else
                {

                    f1[i] = f2[i - 1] + a[0, i] + t[1, i - 1];
                    l1[i] = 2;

                }


                if (f2[i - 1] + a[1, i] <= f1[i - 1] + a[1, i] + t[0, i - 1])
                {
                    f2[i] = f2[i - 1] + a[1, i];
                    l2[i] = 2;
                }
                else
                {

                    f2[i] = f1[i - 1] + a[1, i] + t[0, i - 1];
                    l2[i] = 1;

                }


            }

            if (f1[n - 1] + x1 <= f2[n - 1] + x2)
            {
                f_final = f1[n - 1] + x1;
                l_final = 1;

            }
            else
            {

                f_final = f2[n - 1] + x2;
                l_final = 2;

            }


            PrintPath(a, l1, l2, l_final, n);

        }
        public void PrintPath(int[,] a, int[] path1, int[] path2, int l_final, int n)
        {

            if (n == 0)
            {
                return;
            }

            if (l_final == 1)
            {


                Console.WriteLine("path node is {0} should be in {1}th node and it`s value is {2}", n, l_final, a[0, n - 1]);
                PrintPath(a, path1, path2, path1[n - 1], n - 1);


            }
            else if (l_final == 2)
            {


                Console.WriteLine("path node is {0} should be in {1}th node and it`s value is {2}", n, l_final, a[1, n - 1]);
                PrintPath(a, path1, path2, path1[n - 1], n - 1);

            }

        }

        public void MatrixChainOrder(int[] p, int[,] m, int n)
        {

            int[,] s = new int[n+1, n+1];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                m[i, i] = 0;
            }

            for (int l = 2; l <= n; l++) // length, at least 2 
            {
                for (int i = 1; i <= n - l+1 ; i++)
                {
                    int j = i + l-1 ;
                    m[i, j] = int.MaxValue; 
                    for (int k = i; k < j; k++)
                    {
                        int q = m[i, k] + m[k + 1, j] + p[i-1 ] * p[k] * p[j];

                        if (q < m[i, j])
                        {
                            m[i, j] = q;
                            s[i, j] = k;
                        }
                    }

                }
            }


            PrintOptimalParens(s, 2,5);




        }

        public int RecursiveMatrixChain(int[] p, int[,] m, int i, int j)
        {

            if (i == j)
            {
                return 0;
            }

            for (int a = 0; a <= i; a++)
            {
                for (int b = 0; b <= j; b++)
                {
                    m[a, b] = int.MaxValue;
                }
            }



            for (int k = i; k <= j - 1; k++)
            {
                int q = RecursiveMatrixChain(p, m, i, k) + RecursiveMatrixChain(p, m, k + 1, j) + p[i - 1] * p[k] * p[j];
                if (q < m[i, j])
                {
                    m[i, j] = q;
                }
            }

            return m[i, j];
        }


        public void PrintOptimalParens(int[,] s, int i, int j)
        {
            if (i == j)
            {
                Console.Write("A{0}", j);
            }
            else { 
            
           Console.Write( "(");
          PrintOptimalParens(s, i, s[i, j]);
          PrintOptimalParens(s, s[i, j] + 1, j);
           Console.Write( ")");

            
            
            }

        
        }

    }
}
