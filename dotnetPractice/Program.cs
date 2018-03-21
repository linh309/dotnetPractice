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
            Task<int> primeNumberTask = Task.Run(() =>
                        Enumerable.Range(2, 3000000).Count(n =>
                        Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));

            var awaiter = primeNumberTask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                Console.WriteLine("I just finish");
                var result = awaiter.GetResult();
                Console.WriteLine("Result is: {0}", result);

            });

            Console.WriteLine("End of application");
            Console.ReadLine();
        }
    }
}
