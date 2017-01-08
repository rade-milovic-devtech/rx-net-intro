using System;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace FromOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("From IEnumerable<T>");

            new[] {1, 2, 3}.ToObservable()
                .Subscribe(Console.WriteLine);

            Console.WriteLine("From events");

            Observable.FromEventPattern<ConsoleCancelEventHandler, ConsoleCancelEventArgs>(
                eventHandler => Console.CancelKeyPress += eventHandler,
                eventHandler => Console.CancelKeyPress -= eventHandler
            )
            .Subscribe(consoleCancelledEvent =>
                Console.WriteLine($"Pressed key {consoleCancelledEvent.EventArgs.SpecialKey}")
            );
            Console.ReadKey(true);

            Console.WriteLine("From task");

            Task.Factory.StartNew(() => "Test").ToObservable()
                .Subscribe(
                    Console.WriteLine,
                    () => Console.WriteLine("Completed")
                );
        }
    }
}