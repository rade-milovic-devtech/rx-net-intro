using System;
using System.Reactive.Linq;

namespace WindowOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(10);

            var windowIndex = 0;
            observable.Window(3)
                .Subscribe(
                    window => {
                        Console.WriteLine("--- Starting new window ---");
                        var windowName = $"Window {++windowIndex}";
                        window.Subscribe(
                            value => Console.WriteLine($"{windowName}: {value}"),
                            () => Console.WriteLine($"{windowName}: completed")
                        );
                    },
                    () => Console.WriteLine("Completed")
                );

            Console.Read();
        }
    }
}