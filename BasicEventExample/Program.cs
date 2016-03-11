using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            // Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();
            ep.evt += es.HandleTheEvent;

            // Call the CheckBalance method on the ep object
            // it will invoke the ep.evt delegate if the balance exceeds 250
            ep.CheckBalance(251);

        }
    }

    public class EvtPublisher
    {
        public delegate void del(string x);

        public event del evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                evt("ATTENTION! The current balance exceeds 250...");
            }
        }
    }

    public class EvtSubscriber
    {
        public void HandleTheEvent(string a)
        {
            Console.WriteLine(a);
        }
    }
}
