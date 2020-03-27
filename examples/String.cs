using System;

class Program
{
    static void Mainm(string[] args)
    {
        // 📝 string represents an immutable sequence of Unicode characters.

        var s = "str";

        var length = s.Length; // gets length of s

        var s1 = "Foo";
        var s2 = "Foo";

        // string is a reference type, but follows value-type semantics

        Console.WriteLine(s1 == s2); // True

        // escape sequences:

        Console.WriteLine("C:\\Users");   // C:\Users
        Console.WriteLine("\"Foo\"");     // "Foo"

        // verbatim string literal:
        Console.WriteLine(@"C:\Users");   // C:\Users

        // string concatenation:

        // 1. using + operator

        var s1s2 = s1 + s2;

        // 2. using System.String's Concat method

        Console.WriteLine(System.String.Concat(s1, s2)); // Concat defined in System.String class

        // 3. using System.Text.StringBuilder, useful when you need to concatenate strings many times

        // String interpolation:

        var day = 27;
        var month = 3;
        var year = 2020;

        Console.WriteLine($"date: {day}/{month}/{year}"); // date: 27/3/2020

        var y = 7.12345;
        Console.WriteLine($"{y:F3}"); // 7.123

        Console.ReadKey();
    }
}