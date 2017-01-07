using System;
using System.Reactive.Linq;

namespace AverageOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] {101, 45, 78, 93, 34};
            var observable = numbers.ToObservable();

            observable.Average()
                .Subscribe(Console.WriteLine);
        }
    }
}