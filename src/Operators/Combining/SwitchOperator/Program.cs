using System;
using System.Reactive.Linq;

namespace SwitchOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Observable.Range(0, 3)
                .Select(value => Observable.Range(value, 3))
                .Switch()
                .Subscribe(Console.WriteLine);
        }
    }
}