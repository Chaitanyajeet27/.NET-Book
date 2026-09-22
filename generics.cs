using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    internal class generics <T>
    {
     
        public void display(T value)
        {
            Console.WriteLine("Value: " + value);
        }
    }
}
