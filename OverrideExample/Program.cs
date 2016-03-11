using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine();

            Adult a = new Adult();
            a.Examine();

            Patient pa = new Adult();
            pa.Examine();
        }
    }

    public class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patient has been examined...");
        }
    }
    
    public class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The adult has been examined.");
        }
    }
}
