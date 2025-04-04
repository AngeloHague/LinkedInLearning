// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Whats your name?");
            string str = Console.ReadLine();
            Console.WriteLine($"Hello {str}! This is an inline string interpolation example.");
            Console.WriteLine("This, " + str + ", is an string concatenation example.");
        }
    }
}