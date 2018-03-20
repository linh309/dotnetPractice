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
            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("B");
            }
        }

        static void Main(string[] args)
        {
            //new Thread(WriteX).Start();
            //new Thread(WriteY).Start();

            Task.Run(() => WriteA());
            Task.Run(() => WriteB());

            Console.ReadLine();
        }
    }
}
