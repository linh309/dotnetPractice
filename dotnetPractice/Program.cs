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

        void Go()
        {
            if (!_done)
            {
                _done = true;
                Console.WriteLine("DONE");
            }
        }

        static void Main(string[] args)
        {
            //Thread t = new Thread(WriteY);
            //t.Start();
            ////t.Join();
            ////Console.WriteLine("End WriteY");

            //for(int i = 0; i <= 1000; i++)
            //{
            //    Console.Write("X");
            //}

            Program p = new Program();
            new Thread(p.Go).Start();
            p.Go();


            Console.ReadLine();
        }
    }
}
