using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateExample
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Mark m = new Mark();
            del d;
            d = m.AddNumbers;
            d(5, 6);

            d += m.MultiplyNumbers;
            d(5, 6);

            d += m.SubstractNumbers;
            d(5, 6);
        }
    }

    public class Mark
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("AddNumbers: a + b = {0}", (a + b));
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("MultiplyNumbers: a * b = {0}", (a * b));
        }
        
        public void SubstractNumbers(int a, int b)
        {
            Console.WriteLine("SubstractNumbers: a - b = {0}", (a - b));
        }
    }
}
