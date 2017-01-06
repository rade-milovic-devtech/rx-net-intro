using System;
using System.Linq;
using System.Reactive.Linq;

namespace FirstOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            observable.FirstAsync(number => number > 4)
                .Subscribe(Console.WriteLine);
        }
    }
}