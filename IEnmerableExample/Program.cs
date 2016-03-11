using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnmerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<string>();
            cars.Add("Chevrolet");
            cars.Add("Honda");
            cars.Add("Lexus");
            cars.Add("Ford");

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Car c = new Car();
            c[0] = "Chevrolet";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            foreach (var car in c)
            {
                Console.WriteLine(car);
            }
        }
    }

    public class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum];  }
            set { car[carNum] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var c in car)
            {
                yield return c;
            }
        }

    }

}
