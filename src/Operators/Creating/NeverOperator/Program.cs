using System;
using System.Reactive.Linq;

namespace NeverOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Never<string>();

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}