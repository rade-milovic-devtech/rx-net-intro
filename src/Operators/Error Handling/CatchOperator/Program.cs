using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace CatchOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject = new Subject<int>();

            subject.Catch(Observable.Empty<int>())
                .Finally(() => Console.WriteLine("Finished"))
                .Subscribe(
                    Console.WriteLine,
                    exception => Console.WriteLine(exception.Message),
                    () => Console.WriteLine("Completed")
                );

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnError(new Exception("Error"));
        }
    }
}