using System;

class Program
{
  static void Display(string name)
  {
    if (string.IsNullOrEmpty(name))
      throw new ArgumentNullException(nameof(name), "name can't be null or empty");

    Console.WriteLine($"Hello, {name}");
  }

  static void Main(string[] args)
  {
    // throw: rethrows same exception and preserves original stack trace.
    // throw ex: rethrows exception and resets the stack trace.
    try
    {
      var name = Console.ReadLine();
      Display(name);
    }
    catch (Exception ex)
    {
      //  throw;
      //  throw ex;
      Console.WriteLine(ex.Message);
    }

    Console.ReadKey();
  }
}