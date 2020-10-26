using System;
using System.Threading;
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StopWatch st1 = new StopWatch();
            //StopWatch st2 = new StopWatch();
            Console.WriteLine("{0}",st1.Start());
            for(int i=0;i<200;i++)
            Thread.Sleep(500);
            Console.WriteLine("{0}", st1.Stop());
        }
    }
}
