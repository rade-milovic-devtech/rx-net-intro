using System;
using System.Reactive.Linq;

namespace DelayOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(5).Timestamp();

            observable.Subscribe(
                value => Console.WriteLine($"original : {value}"),
                () => Console.WriteLine("original Completed")
            );

            observable.Delay(TimeSpan.FromSeconds(2))
                .Subscribe(
                    value => Console.WriteLine($"delayed : {value}"),
                    () => Console.WriteLine("delayed Completed")
                );

            Console.Read();
        }
    }
}