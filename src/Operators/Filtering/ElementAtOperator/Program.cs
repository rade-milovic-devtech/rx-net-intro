using System;
using System.Linq;
using System.Reactive.Linq;

namespace ElementAt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var observable = numbers.ToObservable();

            observable.ElementAt(1)
                .Subscribe(Console.WriteLine);
        }
    }
}