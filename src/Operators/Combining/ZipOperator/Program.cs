using System;
using System.Reactive.Linq;

namespace ZipOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable1 = Observable.Interval(TimeSpan.FromMilliseconds(250)).Take(3);
            var observable2 = Observable.Interval(TimeSpan.FromMilliseconds(150)).Take(6)
                .Select(number => char.ConvertFromUtf32((int) number + 97));

            observable1.Zip(
                    observable2,
                    (left, right) => new { Left = left, Right = right }
                )
                .Subscribe(zip =>
                    Console.WriteLine($"{{ {zip.Left}, {zip.Right} }}")
                );

            Console.Read();
        }
    }
}