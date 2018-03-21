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
            var i = 0;
            var b = number / i;
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

            Task<int> primeNumberTask = Task.Run(() =>                Enumerable.Range(2, 3000000)                .Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1)                                        .All(i => n % i > 0)));            Console.WriteLine("Task running...");
            Console.WriteLine("The answer is " + primeNumberTask.Result);
            Task.Run(() => WriteA());
            Task.Run(() => WriteB());

            Console.WriteLine("End of application");
            Console.ReadLine();
        }
    }
}
