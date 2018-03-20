using System;
using System.Threading;
using System.Threading.Tasks;

namespace dotnetPractice
{
    class Program
    {
        bool _done;
        static void WriteA()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.Write("A");
            }
        }

        static void WriteB()
        {
            Thread.Sleep(3000);
            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("B");
            }
        }

        static void Main(string[] args)
        {
            //new Thread(WriteX).Start();
            //new Thread(WriteY).Start();
            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("G");
            }

            Task runB = Task.Run(() => WriteB());
            runB.Wait();

            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("7");
            }
            Task.Run(() => WriteA());
          
            Console.WriteLine("End of application");
            Console.ReadLine();
        }
    }
}
