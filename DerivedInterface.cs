using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    public interface Iinterface1
    {
        void method1();
    }
    public interface Iinterface2 : Iinterface1
    {
        void method2();
    }


    internal class DerivedInterface
    {
        public void method1()
        {
            Console.WriteLine("Method 1 from Iinterface1");
        }
        public void method2()
        {
            Console.WriteLine("Method 2 from Iinterface2");
        }
    }
}
