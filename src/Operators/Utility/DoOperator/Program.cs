using System;
using System.Reactive.Linq;

namespace DoOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(3);

            observable.Do(
                value => Console.WriteLine($"Logging OnNext({value}) @ {DateTime.Now}"),
                exception => Console.WriteLine($"Logging OnError({exception.Message}) @ {DateTime.Now}"),
                () => Console.WriteLine($"Logging OnCompleted() @ {DateTime.Now}")
            )
            .Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("completed")
            );

            Console.Read();
        }
    }
}