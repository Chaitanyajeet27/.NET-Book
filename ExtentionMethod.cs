using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    public static class Extention
    {
        public static string Greet(this string x)
        {
            return "Hello" + x;
        }
    }
}
