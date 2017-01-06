using System;
using System.Linq;
using System.Reactive.Linq;

namespace LastOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            observable.LastAsync(number => number > 4)
                .Subscribe(Console.WriteLine);
        }
    }
}