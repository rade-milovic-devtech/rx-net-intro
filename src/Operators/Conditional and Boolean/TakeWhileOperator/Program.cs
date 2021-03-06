﻿using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace TakeWhileOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject = new Subject<int>();

            subject.TakeWhile(number => number <= 2)
                .Subscribe(Console.WriteLine);

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(5);
        }
    }
}