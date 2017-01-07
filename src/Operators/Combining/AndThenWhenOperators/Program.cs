using System;
using System.Reactive.Linq;

namespace AndThenWhenOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable1 = Observable.Interval(TimeSpan.FromSeconds(1)).Take(5);
            var observable2 = Observable.Interval(TimeSpan.FromMilliseconds(250)).Take(10);
            var observable3 = Observable.Interval(TimeSpan.FromMilliseconds(150)).Take(14);

            Observable.When(
                observable1.And(observable2)
                    .And(observable3)
                    .Then((first, second, third) =>
                        new { First = first, Second = second, Third = third }
                    )
            )
            .Subscribe(zip =>
                Console.WriteLine($"{{ {zip.First}, {zip.Second}, {zip.Third} }}")
            );

            Console.ReadLine();
        }
    }
}
