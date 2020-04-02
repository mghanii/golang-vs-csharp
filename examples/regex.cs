using System;
using System.Text.RegularExpressions;

class Program
{
  static void Main(string[] args)
  {
    // Alphanumeric string that may include _ and – having a length of 3 to 16 characters.
    var regex = new Regex("^[a-z0-9_-]{3,16}$");
    Console.WriteLine(regex.IsMatch("Max"));
    Console.WriteLine(regex.IsMatch("max"));

    // To ignore case use RegexOptions.IgnoreCase or update pattern to ^[A-Za-z0-9_-]{3,16}$
    regex = new Regex("^[a-z0-9_-]{3,16}$", RegexOptions.IgnoreCase);
    Console.WriteLine(regex.IsMatch("Max"));

    // Split string
    var str = "A1B2C3DE4F5";
    regex = new Regex("[0-9]+", RegexOptions.IgnoreCase);

    foreach (var s in regex.Matches(str))
      Console.Write($"'{s}', ");

    Console.Write("\n");

    var strings = Regex.Split(str, "[a-z]+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    foreach (var s in strings)
      Console.Write($"'{s}', ");

    Console.ReadKey();
  }
}