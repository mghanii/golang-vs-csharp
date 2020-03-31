using System;

internal class Program
{
  private static void Main(string[] args)
  {
    object[] arr = new object[]
    {
            44,
            4.5,
            "string",
            DateTime.Now,
            true,
            'a',
            new int[]{1,2,3}
    };

    foreach (var v in arr)
    {
      Console.WriteLine(v.GetType());
    }
    Console.ReadKey();
  }
}