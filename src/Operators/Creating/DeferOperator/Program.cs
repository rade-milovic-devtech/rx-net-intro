using System;
using System.Reactive.Linq;

namespace DeferOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Defer(() => Observable.Return("test"));

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}