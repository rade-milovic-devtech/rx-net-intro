using System;
using System.Reactive.Linq;

namespace BufferOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(10);

            observable.Buffer(3)
                .Subscribe(buffer =>
                    Console.WriteLine($"Buffer of [{string.Join(", ", buffer)}] @ {DateTime.Now}"),
                    () => Console.WriteLine("Completed")
                );

            Console.Read();
        }
    }
}