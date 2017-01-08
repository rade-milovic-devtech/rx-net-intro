using System;
using System.Reactive.Linq;

namespace ReturnOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Return("test");

            observable.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("Completed")
            );
        }
    }
}