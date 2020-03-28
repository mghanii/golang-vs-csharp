using System;

class Program
{
  static void Main(string[] args)
  {
    int a = 4;
    int b = 3;
    int min;

    if (a < b) min = a;
    else min = b;

    // above if statment could be rewritten using ternary operator:
    min = a < b ? a : b;

    if (a == 0)
    {
      Console.WriteLine("x is 0");
    }
    else if (a > 0)
    {
      Console.WriteLine("x is positive");
    }
    else
    {
      Console.WriteLine("x is negative");
    }

    Console.ReadKey();
  }
}