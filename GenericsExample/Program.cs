using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);

            Console.WriteLine("Non-generic List results...");

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(9);
            list2.Add(21);

            Console.WriteLine("Generic list results...");

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
