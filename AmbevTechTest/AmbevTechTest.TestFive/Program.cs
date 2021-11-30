using System;
using System.Threading;

namespace AmbevTechTest.TestFive
{
    public class Racer
    {
        private readonly string name;
        public Racer(string name)
        {
            this.name = name;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new Racer("1").Run);
        }
    }
}
