using System;

class Program
{
  static void Main(string[] args)
  {
    if (args.Length > 0)
    {
      foreach (var arg in args)
        Console.Write(arg + " ");
    }
  }
}