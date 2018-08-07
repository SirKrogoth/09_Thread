using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06_Thread_Auto_Manual
{
    class Program
    {
        //Aqui será listado duas formas de "parar" e "liberar" as threads
        static ManualResetEvent manual01;
        static AutoResetEvent auto01;

        static void Main(string[] args)
        {
            manual01 = new ManualResetEvent(false);

            Thread thread1 = new Thread(Executa01);
            thread1.Start();

            Thread thread2 = new Thread(Executa02);
            thread2.Start();

            Thread.Sleep(5000);
            manual01.Set();

            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado execução 01...");

            manual01.WaitOne();

            Console.WriteLine("02 - Em execução 01...");
            Console.WriteLine("03 - Em execução 01...");
            Console.WriteLine("04 - Finalizandfo execução 01...");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado execução 02...");
            Console.WriteLine("02 - Em execução 02...");
            Console.WriteLine("03 - Em execução 02...");
            Console.WriteLine("04 - Finalizandfo execução 02...");
        }
    }
}
