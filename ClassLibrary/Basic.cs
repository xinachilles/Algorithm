using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    class Basic
    {

        class Equality
        {
            // if the value is refernce type, like point, both will point to a same object 
            // if the value is value type, both are indepentent
            
            public void Equals()
            {
                // Numeric equality: True
                Console.WriteLine((2 + 2) == 4);

                // Reference equality: different objects, 
                // same boxed value: False.
                object s = 1;
                object t = 1;
                Console.WriteLine(s == t);
                // true 
                Console.WriteLine(s.Equals(t));  


                // Define some strings:
                string a = "hello";
                string b = String.Copy(a);
                string c = "hello";

                // Compare string values of a constant and an instance: True
                Console.WriteLine(a == b);

                
                // Compare string references; 
                // a is a constant but b is an instance: False.
                Console.WriteLine((object)a == (object)b);

                // Compare string references, both constants 
                // have the same value, so string interning
                // points to same reference: True.
                Console.WriteLine((object)a == (object)c);

                Console.WriteLine("Eqials");
                Console.WriteLine(a.Equals(b));
                Console.WriteLine(a.Equals(c));
                Console.WriteLine(b.Equals(c));


                //string is refercence type but == will test the value not refercnce
                string a1 = "hello";
                string b1 = "h";
                string b2 = "hello";
                // Append to contents of 'b'
                b += "ello";
                // return true
                Console.WriteLine(a1 == b1);
                // return false 
                Console.WriteLine((object)a1 == (object)b1);
                // return false 
               Console.WriteLine((object)a1 == (object)b2);


            }

            #region reference type
            /*  http://www.albahari.com/valuevsreftypes.aspx */
            //Point myPoint = new Point (0, 0);      // a new value-type variable
            //Form myForm = new Form();              // a new reference-type variable
            //Test (myPoint, myForm);                // Test is a method defined below
 
            ////void Test (Point p, Form f)
            //{
            //      p.X = 100;                       // No effect on MyPoint since p is a copy
            //      f.Text = "Hello, World!";        // This will change myForm’s caption since
            //                                       // myForm and f point to the same object
            //      f = null;                        // No effect on myForm
            //}
            #endregion 
        }
    }

}