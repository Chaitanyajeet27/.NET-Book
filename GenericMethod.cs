using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    internal class GenericMethod 
    {
        
        public void Swap<T>(ref T x, ref T y)
        {
            T temp;
            Console.WriteLine($"Variable A : {x} , Variable B : {y}");
            temp = x;
            x = y;
            y = temp;
            
        }
    }
}
