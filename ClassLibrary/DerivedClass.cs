using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Derived
{
    class DerivedClassTest
    {

        class BaseClass
        {
            public virtual void Method1()
            {
                Console.WriteLine("Base - Method1");
            }

            public void Method2()
            {
                Console.WriteLine("Base - Method2");
            }
        }

        class DerivedClass : BaseClass
        {
           new public void Method2()
            {
                Console.WriteLine("Derived - Method2");
            }

            public override void Method1()
            {
                Console.WriteLine("Derived - Method1");
            }
            
        }

           
            public void testD()
            {
                BaseClass bc = new BaseClass();
                DerivedClass dc = new DerivedClass();
                BaseClass bcdc = new DerivedClass();

                bc.Method1();
                bc.Method2();
                dc.Method1();
                dc.Method2();
                bcdc.Method1();
                bcdc.Method2();
                            
            }
        
    
    }
}
