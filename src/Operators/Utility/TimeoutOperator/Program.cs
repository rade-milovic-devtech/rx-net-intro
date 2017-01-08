using System;
using System.Reactive.Linq;

namespace TimeoutOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(100))
                .Take(3)
                .Concat(Observable.Interval(TimeSpan.FromSeconds(2)));

            observable.Timeout(TimeSpan.FromSeconds(1))
                .Subscribe(
                    Console.WriteLine,
                    Console.WriteLine,
                    () => Console.WriteLine("Completed")
                );

            Console.Read();
        }
    }
}