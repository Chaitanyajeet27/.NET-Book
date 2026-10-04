using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    internal class ArrayOfObjects : IComparable<ArrayOfObjects>
    {
     public string name {  get; set; }
     public int age { get; set; }

        public int CompareTo(ArrayOfObjects obj)
        {
            return age.CompareTo(obj.age);
        }
    }
}
