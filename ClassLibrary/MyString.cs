﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyString
    {
        private string testString;
      
        private static void sortStr(ref string s)
        {

        }

        #region 1.1
        /*Implement an algorithm to determine if a string has all unique characters. What if
        you cannot use additional data structures?*/

        public bool IsUniqueChars(String str)
        {


            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }


        #endregion 

        #region 1.3
        //   Given two strings, write a method to decide if one is a permutation of the other.
        public Boolean permutation2(String str1, String str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not permutation of the other.");
                return false;
            }

            int[] check = new int[256]; // assumption if ASCII code   
            foreach (char c in str1)
            {
                check[(int)c] = check[(int)c] + 1;
            }


            for (int i = 0; i < str2.Length; i++)
            {
                int m = (int)str2[i];
                if (--check[m] < 0)
                {
                    Console.WriteLine("Not permutation of the other.");
                    return false;
                }
            }
            return true;
        }
        #endregion "1.3"
        #region 1.6

        //Given an image represented by an nxn matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?

        public void Rotate(int[][] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    // save top
                    int top = matrix[first][i];

                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right
                    matrix[i][last] = top;
                }
            }
        }



        #endregion
        # region 1.8
        //Assume you have a method isSubstring which checks if one word is a substring of another. Given two strings, s1 and s2, write code to check If s2 is a rotation of s1
        // using only onecalltoisSubstring (e.g., "waterbottLe" is a rotation of "erbottLewat").

        // So, we need to check if there's a way to split si into x and y such that xy = s1 and yx =
        //s2. Regardless of where the division between x and y is, we can see that yx will always
        //be a substring of xyxy.That is, s2 will always be a substring of slsl.

        public bool IsRotation(String s1, String s2)
        {
            int len = s1.Length;
            /* check that si and s2 are equal length and not empty */
            if (len == s2.Length && len > 0)
            {
                /* concatenate si and si within new buffer */
                String s1s1 = s1 + s1;
                return IsSubstring(s1s1, s2);
            }
            return false;
        }

        public bool IsSubstring(string strMainString, string strSubString)
        {


            int[] letters = new int[256];
            foreach (char c in strSubString)
            {
                letters[(int)c] = letters[(int)c] + 1;
            }

            foreach (char c in strMainString)
            {
                letters[(int)c] = letters[(int)c] - 1;

            }

            foreach (int item in letters)
            {
                if (item > 0)
                {
                    return false;
                }
            }

            return true;

        }


        #endregion

        private string revStr()
        {
            
            if (testString != null)
            {
                char[] r = new char[ testString.Length];
                int i;
                int n;
                n = testString.Length - 1;


                for (i = 0; i < testString.Length; i++)
                {
                    r[n] = testString[i];
                    n--;
                }

                return new string(r);


            }

            return null;


        }

        private void contactString(ref string a1, ref string a2)
        {
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";

            // Concatenate s1 and s2. This actually creates a new 
            // string object and stores it in s1, releasing the 
            // reference to the original object.
            s1 += s2;

            System.Console.WriteLine(s1);

            s1 = "Hello";
            s2 = s1;
            s1 += "World";

            System.Console.WriteLine(s2);

        }


        private string  Uniquecharacters()
        {
            string result = null;
            if (testString != null)
            {
               
                int i;
               

                for (i = 0; i <= testString.Length - 1; i++)
                {
                    char a = testString[i];
                    bool unique = true;
                    for (int j = 0; j < testString.Length; j++)
                    {
                        if (a == testString[j]&& j!=i)
                        {
                            unique = false;
                            break;
                            
                        }

                    }

                    if (unique) result += a;


                }

                
            }

            return result;

        }

        
        public static void repSpa(ref string s)
        {
            char[] n = s.ToArray();
            char[] space = new char[0];


            for (int i = 0; i < s.Length; i++)
            {
                if (n[i] == space[0])
                {
                    InsStr(ref n, "aa", i);
                }
            }

        }

        public MyString(string t)
        { 
            testString  = t;
        }


        public static void InsStr(ref char[] old, string s, int index)
        {
            string n = new string(old);
            n.Insert(index, s);
            old = n.ToArray();
        }

        public string ComStr()
        {

            for (int i = 0; i < testString.Length - 1; i++)
            {

                int j = i;
                int number = 1;


                while ((testString[j] == testString[j + 1]))
                {


                    j = j + 1;
                    number = number + 1;

                    if (j >= (testString.Length - 1))
                    {
                        break;
                    }
                }


                if (number > 0)
                {
                    testString = testString.Remove(i + 1, number - 1);
                    testString = testString.Insert(i + 1, number.ToString());
                    i = i + 1;
                }


            }

            return testString;


        }
        public string RepStr(string inString)
        {
            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i]  == ' ')
                {
                   testString = testString.Remove(i,1);
                   testString= testString.Insert(i, inString);
                       
                }

               
            }

            return testString;
        }

       
    
    }
}



