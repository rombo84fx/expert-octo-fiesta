using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = "hello";

            Console.WriteLine("{0} is captilized? {1}", x, x.IsCap());
            Console.WriteLine("{0} is captilized? {1}", y, y.IsCap());
        }
    }

    public static class StringCap
    {
        public static bool IsCap(this String s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            return char.IsUpper(s[0]);
        }
    }
}
