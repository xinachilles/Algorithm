using System;
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

            s1 = "Hello ";
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

        //      public static void permutation2(String str1, String str2){  
        //  if (str1.Length != str2.Length)
        //  {  
        //      Console.WriteLine("Not permutation of the other.");  
        //      return; 
        //  }  

        //   int[] check = new int[256]; // assumption if Unicode with a large array  
        //   char[] temp = str1.ToArray();  
        //   for (int i = 0;i<str1.Length;i++) // count number of each char in temp
        //   {
        //     check[c-'a']++; // careful with ArrayOutBound  
        //   }


        //   for (int i=0; i< str2.Length; i++){  
        //     int m = (int)str2[i];  
        //     if (--temp[m-'a'] < 0){  
        //      Console.WriteLine("Not permutation of the other.");  
        //       return;  
        //     }  
        //   }  
        //   Console.WriteLine("Yes permutation of the other.");  
        //}  

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



