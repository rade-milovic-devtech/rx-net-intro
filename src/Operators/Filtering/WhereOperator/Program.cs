using System;
using System.Linq;
using System.Reactive.Linq;

namespace WhereOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            observable.Where(number => number % 2 == 0)
                .Subscribe(Console.WriteLine);
        }
    }
}