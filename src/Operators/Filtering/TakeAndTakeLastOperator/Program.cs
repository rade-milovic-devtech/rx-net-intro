using System;
using System.Linq;
using System.Reactive.Linq;

namespace TakeAndTakeLastOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            Console.WriteLine("Take:");
            observable.Take(3)
                .Subscribe(Console.WriteLine);

            Console.WriteLine();

            Console.WriteLine("TakeLast:");
            observable.TakeLast(3)
                .Subscribe(Console.WriteLine);
        }
    }
}