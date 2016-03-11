using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine1 m1 = new Machine1();
            Machine2 m2 = new Machine2();
            Machine3 m3 = new Machine3();

            Mark m = new Mark();
            ((IFirst)m).DoThis();

            ((ISecond)m).DoThis();

            ISecond mm = new Mark();
            mm.DoThis();
            
        }
    }

    public class Machine1 : IControls
    {

        void IControls.Start()
        {
            throw new NotImplementedException();
        }

        void IControls.Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Machine2 : IControls
    {

        void IControls.Start()
        {
            throw new NotImplementedException();
        }

        void IControls.Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Machine3 : IControls
    {

        void IControls.Start()
        {
            throw new NotImplementedException();
        }

        void IControls.Stop()
        {
            throw new NotImplementedException();
        }
    }

    interface IControls
    {
        void Start();
        void Stop();
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class Mark : IFirst, ISecond
    {

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis...");
            return 4;
        }

        public void Test()
        {
            //TODO
        }

        void IFirst.DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis...");
        }
    }
}
