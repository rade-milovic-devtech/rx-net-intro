using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace AmbOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject1 = new Subject<int>();
            var subject2 = new Subject<int>();

            subject1.Amb(subject2)
                .Subscribe(Console.WriteLine);

            subject1.OnNext(1);
            subject2.OnNext(2);
            subject1.OnNext(3);
            subject2.OnNext(4);
            subject1.OnNext(5);
            subject2.OnNext(6);
        }
    }
}