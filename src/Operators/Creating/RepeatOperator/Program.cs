using System;
using System.Reactive.Linq;

namespace RepeatOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Repeat("test", 3);

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}