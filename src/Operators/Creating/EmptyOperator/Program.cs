using System;
using System.Reactive.Linq;

namespace EmptyOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Empty<string>();

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}