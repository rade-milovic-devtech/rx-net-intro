using System;
using System.Reactive.Linq;

namespace RefCountOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1))
                .Do(count => Console.WriteLine($"Publishing {count}"))
                .Publish()
                .RefCount();

            var subscription = observable.Subscribe(value =>
                Console.WriteLine($"subscription: {value}"),
                () => Console.WriteLine("Completed")
            );

            Console.WriteLine("Press any key to unsubscribe");
            Console.Read();
            subscription.Dispose();
        }
    }
}