using System;
using System.Reactive.Linq;

namespace GroupByOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(100))
                .Take(10);

            observable.GroupBy(timestamp => timestamp % 3)
                .SelectMany(group =>
                    group.Max()
                        .Select(value => new { group.Key, Value = value})
                )
                .Subscribe(maxValueGroup =>
                    Console.WriteLine($"{maxValueGroup.Key} -> {maxValueGroup.Value}")
                );

            Console.Read();
        }
    }
}