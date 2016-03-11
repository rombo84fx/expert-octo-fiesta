using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Jamison");

            Child c = new Child();
            c.Inoculate();

            c.Examine("Bobby");

            UnderFive uf = new UnderFive();
            uf.Inoculate();
        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pname)
        {
            Console.WriteLine("Examination of {0} completed", pname);
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed...");
        }
    }

    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been inoculated...");
        }
    }

    public class UnderFive : Child
    {
        public void UnderFiveMethod()
        {
            Console.WriteLine("UnderFive method has been called...");
        }
    }
}
