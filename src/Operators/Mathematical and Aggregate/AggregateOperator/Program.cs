using System;
using System.Reactive.Linq;

namespace AggregateOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] {101, 45, 78, 93, 33};
            var observable = numbers.ToObservable();

            observable.Aggregate((accumulated, current) => accumulated + current)
                .Subscribe(Console.WriteLine);
        }
    }
}