using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace RetryOperator
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
                observer.OnError(new Exception());

                return Disposable.Empty;
            });

            observable.Retry(2)
                .Subscribe(
                    Console.WriteLine,
                    _ => Console.WriteLine("Error"),
                    () => Console.WriteLine("Completed")
                );
        }
    }
}