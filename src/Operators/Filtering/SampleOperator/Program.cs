using System;
using System.Reactive.Linq;

namespace SampleOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(150));

            observable.Sample(TimeSpan.FromSeconds(1))
                .Timestamp()
                .Subscribe(next => Console.WriteLine($"{next.Timestamp}: {next.Value}"));

            Console.Read();
        }
    }
}