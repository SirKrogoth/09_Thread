using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_Thread_ID
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(ThreadRepeticao);

                t.Start(i);                
            }

            Console.ReadKey();

        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + id + " - Número: " + i + " ID interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
