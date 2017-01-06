using System;
using System.Reactive.Linq;

namespace DistinctOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] { 1, 1, 2, 3, 4, 4, 4, 5 };
            var observable = numbers.ToObservable();

            observable.Distinct()
                .Subscribe(Console.WriteLine);
        }
    }
}