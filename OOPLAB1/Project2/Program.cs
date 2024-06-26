﻿using System;
using System.ComponentModel.DataAnnotations;
namespace Project2
{
    internal class Program
    {
        static void Main()
        {
            IDateTimePrinter europeanDateTimePrinter = new EuropeanDateTimePrinter();
            IDateTimePrinter americanDateTimePrinter = new AmericanDateTimePrinter();

            IDateTimePrinter decoratedEuropeanDateTime = new SuffixDecorator(new PrefixDecorator(europeanDateTimePrinter, "AND "), "BOK");
            IDateTimePrinter decoratedAmericanDateTime = new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "AND "), "BOK");

            Console.WriteLine("Decorated European DateTime: " + decoratedEuropeanDateTime.Print());
            Console.WriteLine("Decorated American DateTime: " + decoratedAmericanDateTime.Print());
        }
    }
}