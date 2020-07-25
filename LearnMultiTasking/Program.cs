using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnMultiTasking
{
    class  Work
    {
        public void Count()
        {
            Console.WriteLine("Thread 1 Start");
            for (int i=0;i<100;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 1 End");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            Console.WriteLine("Main Thread Start");

            ThreadStart s = w.Count;
            Thread thread1 = new Thread(s);
            thread1.Start();

            Console.WriteLine("Main Thread Ends");
            Console.ReadKey();

        }
    }
}
