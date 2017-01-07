using System;
using System.Linq;
using System.Reactive.Linq;

namespace SelectManyOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 3);
            var observable = numbers.ToObservable();

            observable.SelectMany(number => Observable.Range(1, number))
                .Subscribe(Console.WriteLine);
        }
    }
}