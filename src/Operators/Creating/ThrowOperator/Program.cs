using System;
using System.Reactive.Linq;

namespace ThrowOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Throw<string>(new Exception("Error"));

            observable.Subscribe(
                Console.WriteLine,
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}