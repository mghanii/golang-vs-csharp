using System;

class Program
{
  static void Swap(ref int a, ref int b)
  {
    var temp = a;
    a = b;
    b = temp;
  }

  static void Main(string[] args)
  {
    var a = 3;
    var b = 5;
    Swap(ref a, ref b);
    Console.WriteLine($"{a} {b}"); // 5 3
    Console.ReadKey();
  }
}