using System;
using System.Reactive.Linq;

namespace ThrottleOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1));

            observable.Throttle(TimeSpan.FromMilliseconds(1500))
                .Timestamp()
                .Subscribe(next => Console.WriteLine($"{next.Timestamp}: {next.Value}"));

            Console.Read();
        }
    }
}