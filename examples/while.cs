using System;

class Program
{
  static void Main(string[] args)
  {
    var attempt = 1;

    while (attempt <= 3)
    {
      Console.WriteLine($"attempt # {attempt}");
      // do other stuff
      attempt++;
    }

    // use break to exit
    while (true)
    {
      break;
    }

    // do ... while: executed at least 1 time
    do
    {
      Console.WriteLine("do while...");
    } while (false);

    Console.ReadKey();
  }
}