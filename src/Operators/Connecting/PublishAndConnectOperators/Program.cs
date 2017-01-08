using System;
using System.Reactive.Linq;
using System.Threading;

namespace PublishAndConnectOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Publish();

            observable.Connect();
            observable.Subscribe(value =>
                Console.WriteLine($"first subscription: {value}")
            );
            Thread.Sleep(TimeSpan.FromSeconds(1));
            observable.Subscribe(value =>
                Console.WriteLine($"second subscription: {value}")
            );

            Console.Read();
        }
    }
}