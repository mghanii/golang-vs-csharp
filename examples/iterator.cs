using System;
using System.Collections.Generic;

class Program
{
  static IEnumerable<int> Where(IEnumerable<int> values, Func<int, bool> predicate)
  {
    foreach (var v in values)
    {
      if (predicate(v))
        yield return v;
    }
  }

  static void Main(string[] args)
  {
    var values = new[] { 1, 2, 3, 4, 5, 6 };
    var odds = Where(values, v => v % 2 == 1);

    foreach (var v in odds)
      Console.Write(v + ", ");

    Console.ReadKey();
  }
}