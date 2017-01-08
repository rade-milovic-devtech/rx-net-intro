using System;
using System.Reactive.Linq;

namespace UsingOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Using(
                () => new TimeIt("Subscription Timer"),
                timeIt => Observable.Interval(TimeSpan.FromSeconds(1))
            );

            observable.Take(3)
                .Subscribe(
                    Console.WriteLine,
                    () => Console.WriteLine("Completed")
                );

            Console.Read();
        }
    }
}