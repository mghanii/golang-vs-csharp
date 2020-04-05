using System;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    if (args.Length > 0)
    {
      var flags = args
          .Select(x => x.Split('='))
          .ToDictionary(x => x[0], x => x[1]);

      foreach (var kv in flags)
      {
        Console.Write($"{kv.Key}: {kv.Value}\n");
      }
    }
  }
}