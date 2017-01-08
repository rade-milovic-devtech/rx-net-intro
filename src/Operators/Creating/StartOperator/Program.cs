using System;
using System.Reactive.Linq;
using System.Threading;

namespace StartOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("On main thread.");

            var observable = Observable.Start(() =>
            {
                Console.WriteLine("From backgound thread.");
                Console.WriteLine("Calculating...");
                Thread.Sleep(3000);
                Console.WriteLine("Background work completed.");

                return 100;
            });

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );

            observable.Wait();
        }
    }
}