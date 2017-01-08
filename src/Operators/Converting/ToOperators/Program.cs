using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;

namespace ToOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Create<int>(observer =>
            {
                observer.OnNext(0);
                observer.OnNext(1);
                observer.OnError(new Exception("Error!"));

                return Disposable.Empty;
            });

            Console.WriteLine("To IEnumerable<T>");

            var enumerable = observable.ToEnumerable();
            try
            {
                foreach (var value in enumerable)
                {
                    Console.WriteLine(value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("To Event");

            var observableEvent = observable.ToEvent();
            try
            {
                observableEvent.OnNext += Console.WriteLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("To Task");

            var task = observable.ToTask();
            try
            {
                Console.WriteLine(task.Result);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}