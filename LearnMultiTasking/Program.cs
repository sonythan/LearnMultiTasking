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

        public void Alphabets()
        {
            Console.WriteLine("Trhead 2 Start");
            for (char c = 'A'; c <= 'Z'; c++) 
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Thread 2 End");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            Console.WriteLine("Main Thread Start");

            ThreadStart s1 = w.Count;
            ThreadStart s2 = w.Alphabets;

            Thread thread1 = new Thread(s1);
            Thread thread2 = new Thread(s2);

            thread1.Start();
            thread2.Start();

            Console.WriteLine("Main Thread Ends");
            Console.ReadKey();

        }
    }
}
