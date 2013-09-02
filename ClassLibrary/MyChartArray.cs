using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class MyChartArray
    {
        private char[] testCharArray;
        private int[,] testMatrix;

        public MyChartArray(char[] s)
        {
            testCharArray = s;

        }

        public MyChartArray(int[,] s)
        {
            testMatrix = s;
        }
        private char[] Insert(int index, char a)
        {
            if ( (testCharArray.Length > 0) && (index <= testCharArray.Length -1))
            {
                Array.Resize<char>(ref testCharArray, testCharArray.Length + 1);
                for (int i = testCharArray.Length - 1; i > index; i--)
                {
                    testCharArray[i] = testCharArray[i - 1];
                }

                testCharArray[index] = a;

            }

            return testCharArray;

        }

        private  char[] Replace(int index,char a)
        {
            if ((testCharArray.Length > 0) && (index <= testCharArray.Length -1))
            {
                testCharArray[index] = a;
            
            }
            return testCharArray;
        }

        public int[,] ReplaceMatrix()
        {
            for (int i = 0; i < testMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.GetLength(1); j++)
                {
                    if (testMatrix[i, j] == 0)
                    {
                        for (int m = 0; m < testMatrix.GetLength(1); m++)
                        {
                            testMatrix[i, m] = 0;
                        }

                        for (int n = 0; n <testMatrix.GetLength(0); n++)
                        {
                            testMatrix[n, j] = 0;
                        }

                        break;
                    }
                }
            }

            return testMatrix;
        
        }

       private char[] Remove(char[] s,int index,int count)
        {
           if ((s !=null) && ((index+count) < s.Length) && (index >0) && (count >0))  
            {
            int j = index;
            for (int i = index+count ; i < s.Length; i++)
            {
                s[j] = s[i];
                j = j + 1;
            }

            Array.Resize<char>(ref s, (s.Length - count)); 
        }
            return s;
        
        }

        public bool ComChar( char[] a)
        {
            

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < testCharArray.Length; j++)
                {
                    if (a[i] == testCharArray[j])
                    {
                        a = Remove(a,i, 1);
                       testCharArray =Remove(testCharArray,j,1);
                       break;
                   
                    }

                    return false;

                }

                
            }

            return true;
        }


        
    }
        
}
