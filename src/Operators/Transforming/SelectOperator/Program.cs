using System;
using System.Linq;
using System.Reactive.Linq;

namespace SelectOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            observable.Select(number => number + 3)
                .Subscribe(Console.WriteLine);
        }
    }
}