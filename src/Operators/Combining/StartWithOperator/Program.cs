using System;
using System.Reactive.Linq;

namespace StartWithOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Observable.Range(0, 3)
                .StartWith(-3, -2, -1)
                .Subscribe(Console.WriteLine);
        }
    }
}