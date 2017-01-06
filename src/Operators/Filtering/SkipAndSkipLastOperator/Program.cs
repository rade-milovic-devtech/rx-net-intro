using System;
using System.Linq;
using System.Reactive.Linq;

namespace SkipOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            Console.WriteLine("Skip:");
            observable.Skip(3)
                .Subscribe(Console.WriteLine);

            Console.WriteLine();

            Console.WriteLine("SkipLast:");
            observable.SkipLast(3)
                .Subscribe(Console.WriteLine);
        }
    }
}