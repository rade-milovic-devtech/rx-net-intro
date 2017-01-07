using System;
using System.Reactive.Linq;

namespace SequenceEqualsOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers1 = new[] {1, 2, 3, 4};
            var observable1 = numbers1.ToObservable();
            var numbers2 = new[] {1, 2, 3, 4, 5};
            var obserbable2 = numbers2.ToObservable();

            observable1.SequenceEqual(obserbable2)
                .Subscribe(Console.WriteLine);
        }
    }
}