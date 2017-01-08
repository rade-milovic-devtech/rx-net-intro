using System;
using System.Reactive.Linq;

namespace ForEachOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(5);

            observable.ForEachAsync(value =>
                Console.WriteLine($"received {value} @ {DateTime.Now}")
            );

            Console.Read();
        }
    }
}