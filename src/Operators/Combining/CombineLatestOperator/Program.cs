using System;
using System.Reactive.Linq;

namespace CombineLatestOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable1 = Observable.Interval(TimeSpan.FromSeconds(1)).Take(5);
            var observable2 = Observable.Interval(TimeSpan.FromMilliseconds(250)).Take(10);

            observable1.CombineLatest(
                    observable2,
                    (left, right) => left + right
                )
                .Timestamp()
                .Subscribe(timestampedValue =>
                    Console.WriteLine($"{timestampedValue.Value}: {timestampedValue.Timestamp}")
                );

            Console.Read();
        }
    }
}