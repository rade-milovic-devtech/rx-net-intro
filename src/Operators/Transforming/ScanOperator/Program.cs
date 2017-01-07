using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ScanOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(number => Console.WriteLine($"Subject: {number}"));

            subject.Scan(0, (accumulated, current) => accumulated + current)
                .Subscribe(number => Console.WriteLine($"Scan: {number}"));

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
        }
    }
}