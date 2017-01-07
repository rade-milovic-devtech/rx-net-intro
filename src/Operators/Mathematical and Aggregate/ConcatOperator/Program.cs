using System;
using System.Reactive.Linq;

namespace ConcatOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable1 = Observable.Range(1, 5);
            var observable2 = Observable.Range(6, 5);

            observable1.Concat(observable2)
                .Subscribe(Console.WriteLine);
        }
    }
}