using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnetPractice
{
    class Program
    {
        bool _done;
        static void WriteA()
        {
            var number = 10;
            var divided = 0;
            var b = number / divided;
            for (int i = 0; i <= 1000; i++)
            {
                Console.Write("A");
            }
        }

        static void WriteB()
        {
            //Thread.Sleep(3000);
            for (int i = 0; i <= 3000; i++)
            {
                Console.Write("B");
            }
        }

        static void RunException()
        {
            Task task = Task.Run(() => { throw null; });
            try
            {
                task.Wait();
            }
            catch (AggregateException aex)
            {
                if (aex.InnerException is NullReferenceException)
                    Console.WriteLine("Null exception from Task!");
                else
                    throw;
            }
        }
      
        static void Main(string[] args)
        {
            //new Thread(WriteX).Start();
            //new Thread(WriteY).Start();
            //for (int i = 0; i <= 3000; i++)
            //{
            //    Console.Write("G");
            //}

            //Task runB = Task.Run(() => WriteB());
            //runB.Wait();

            //for (int i = 0; i <= 3000; i++)
            //{
            //    Console.Write("7");
            //}
            //Task.Run(() => WriteA());

            Task task = Task.Run(() => RunException());
            //task.Wait();
            Task.Run(() => WriteB());

            Console.WriteLine("End of application");
            Console.ReadLine();
        }
    }
}
