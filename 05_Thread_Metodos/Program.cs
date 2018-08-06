using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _05_Thread_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep
            Console.WriteLine("Iniciando nosso programa...");
            Thread.Sleep(3000);            

            //Thread Join
            Thread t = new Thread(ThreadRepeticao);
            t.Start();
            //Irá esperar a Thread principal espere a thread secundária 
            t.Join();

            Console.WriteLine("Telecon Sistemas");
            Console.WriteLine("Telecon Sistemas");
            Console.WriteLine("Telecon Sistemas");
            Console.WriteLine("Telecon Sistemas");

            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("i: " + i + " ID interno: " + "" + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
