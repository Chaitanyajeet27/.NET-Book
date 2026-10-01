using System;
using System.Collections.Generic;
using System.Text;

namespace c__Book
{
    public class overload
    {
        public string name;
        public int age;

        public static overload operator +(overload a, overload b)
        {
            var c = new overload();
            c.name = a.name + b.name;
            c.age = a.age + b.age;

            return c;
        }
    }
}
