using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new  Thread(ThreadRepeticao);

            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();

        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Repetição: " + i);
            }
        }
    }
}
