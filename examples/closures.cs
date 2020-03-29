using System;

internal class Program
{
  static Func<int> Sequence(int start = 0)
  {
    // Closure captures method parameter
    return () => start++;
  }

  static void Main(string[] args)
  {
    var stepSize = 2;
    Func<int, int> incrementer = value => value + stepSize;
    stepSize = 5;
    Console.WriteLine(incrementer(3)); // 8

    // The lifetime of captured method parameter is extended to that of the capturing delegate (seq)
    var seq = Sequence();
    Console.WriteLine(seq()); // 0
    Console.WriteLine(seq()); // 1
    Console.WriteLine(seq()); // 2

    var seq2 = Sequence();
    Console.WriteLine(seq2()); // 0

    // Capturing iteration variables

    // Below code is intended to print 01234
    var func = new Func<int>[5];
    for (int i = 0; i < 5; i++)
      func[i] = () => i;

    foreach (var f in func)
      Console.Write(f()); // 55555

    // In this example iteration variable "i" is treaded as it's declared outside the for statement.
    // To get the expected result, define a new variable inside the loop, copy the iteration value to that.
    for (int i = 0; i < 5; i++)
    {
      int k = i;
      func[i] = () => k;
    }

    foreach (var f in func)
      Console.Write(f()); // 01234

    Console.ReadKey();
  }
}