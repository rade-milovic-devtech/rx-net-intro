using System;
using System.Reactive.Linq;

namespace SumOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] {101, 45, 78, 93, 33};
            var observable = numbers.ToObservable();

            observable.Sum()
                .Subscribe(Console.WriteLine);
        }
    }
}