using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Thread
{
    class Program
    {
        static void Main(string[] args)
        {            

            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(ThreadRepeticao);

                t.Start();
            }

            Console.WriteLine("###################Finalizado o programa #####################");
            Console.ReadKey();

        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Repetição: " + i);
            }
        }
    }
}
