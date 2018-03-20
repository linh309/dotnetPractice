using System;
using System.Threading;

namespace dotnetPractice
{
    class Program
    {
        bool _done;
        static void WriteY()
        {
            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("Y");
            }
        }

        static void WriteX()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.Write("X");
            }
        }

        static void Main(string[] args)
        {
            new Thread(WriteX).Start();
            new Thread(WriteY).Start();

            Console.ReadLine();
        }
    }
}
