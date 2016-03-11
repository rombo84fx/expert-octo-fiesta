using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = "Dodge";
            c[3] = "Chevloret";
            c[4] = "Honda";

            Console.WriteLine("Car 1 is: {0}", c[1]);
            Console.WriteLine("Car 2 is: {0}", c[2]);
            Console.WriteLine("Car 3 is: {0}", c[3]);
            Console.WriteLine("Car 4 is: {0}", c[4]);

        }
    }

    public class Car
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    return car[carNum];
                }
                throw new IndexOutOfRangeException("Out of index range...");
            }

            set
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    car[carNum] = value;
                }
            }
        }

    }
}
