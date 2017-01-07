using System;
using System.Reactive.Linq;

namespace DefaultIfEmptyOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Empty<int>();

            observable.DefaultIfEmpty(50)
                .Subscribe(Console.WriteLine);
        }
    }
}