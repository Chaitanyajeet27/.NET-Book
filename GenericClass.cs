using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    internal class GenericClass <T>
    {
        T value;
        public GenericClass(string type , T value )
        {
            this.value = value;
            Console.WriteLine($"{type} : {value}");
        }
    }
}
