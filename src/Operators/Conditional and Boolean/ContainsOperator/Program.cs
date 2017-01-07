using System;
using System.Reactive.Linq;

namespace ContainsOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] {1, 2, 3, 4, 5};
            var observable = numbers.ToObservable();

            observable.Contains(2)
                .Subscribe(Console.WriteLine);
        }
    }
}