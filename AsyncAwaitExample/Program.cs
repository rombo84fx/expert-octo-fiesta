using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuffAsync();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the main Thread........");
            }
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuffAsync()
        {
            await Task.Run(() =>
            {
                CountToFiftyAsync();
            });

            // This will not execute until CountToFifty has completed
            Console.WriteLine("Counting to 50 is completed...");
        }

        private static async Task<string> CountToFiftyAsync()
        {
            int counter;
            for (counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("BG thread: {0}", counter);
            }

            return String.Format("Counter = {0}", counter);
        }
    }
}
