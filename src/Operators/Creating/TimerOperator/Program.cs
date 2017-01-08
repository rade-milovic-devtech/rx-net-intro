using System;
using System.Reactive.Linq;

namespace TimerOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Timer(TimeSpan.FromSeconds(1));

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );

            Console.Read();
        }
    }
}