using System;
using System.Reactive.Linq;

namespace TimestampAndTimeIntervalOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(3);

            observable.Timestamp()
                .Subscribe(value => Console.WriteLine($"Timestamp: {value}"));

            observable.TimeInterval()
                .Subscribe(value => Console.WriteLine($"Time interval: {value}"));

            Console.Read();
        }
    }
}