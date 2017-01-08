using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace CreateOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Create<int>(observer =>
            {
                observer.OnNext(0);
                observer.OnNext(1);
                observer.OnNext(2);
                observer.OnCompleted();

                return Disposable.Empty;
            });

            observable.Subscribe(Console.WriteLine);
        }
    }
}