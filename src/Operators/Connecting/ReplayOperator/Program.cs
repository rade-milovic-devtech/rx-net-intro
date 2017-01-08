using System;
using System.Reactive.Linq;
using System.Threading;

namespace ReplayOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1))
                .Take(3)
                .Publish();

            observable.Connect();
            Thread.Sleep(TimeSpan.FromSeconds(1));

            var otherObservable = observable.Replay();
            otherObservable.Connect();
            otherObservable.Subscribe(value =>
                Console.WriteLine($"first subscription: {value}")
            );

            otherObservable.Subscribe(value =>
                Console.WriteLine($"second subscription: {value}")
            );
            Console.Read();

            otherObservable.Subscribe(value =>
                Console.WriteLine($"third subscription: {value}")
            );
            Console.Read();
        }
    }
}