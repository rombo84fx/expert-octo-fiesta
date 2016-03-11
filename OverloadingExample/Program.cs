using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling();
            p.CheckBilling(3, 3);
            p.CheckBilling("Gerardo", 3);

            Child c = new Child();
            c.CheckBilling("b", "c");
        }
    }

    public class Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has benn checked...");
        }

        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing checked with a string and an int");
        }
    }

    public class Child : Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing with two strings");
        }
    }
}
