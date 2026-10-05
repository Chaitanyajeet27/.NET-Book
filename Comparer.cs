using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace c__Book
{
    internal class Comparer : IComparer<ArrayOfObjects>
    {
       
        public int Compare(ArrayOfObjects? x, ArrayOfObjects? y)
        {
            return x.age.CompareTo(y.age);       }
    }
}
