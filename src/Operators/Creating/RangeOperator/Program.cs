using System;
using System.Reactive.Linq;

namespace RangeOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Range(0, 3);

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}