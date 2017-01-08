using System;
using System.Linq;
using System.Reactive.Linq;

namespace MaterializeAndDematerializeOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 5);
            var observable = numbers.ToObservable();

            var materialized = observable.Materialize();
            materialized.Subscribe(Console.WriteLine);

            var dematerialized = materialized.Dematerialize();
            dematerialized.Subscribe(Console.WriteLine);
        }
    }
}