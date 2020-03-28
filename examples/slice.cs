using System;

class Program
{
  static void Main(string[] args)
  {
    // C# doesn't have a type equivalent to golang's slice type
    // However, System.Collections.Generic.List<T> is the most similar collection to slice:
    // ♦ List is implemented using an underlying array.
    // ♦ Its size is dynamically resized.
    // ♦ Has O(1) amortized time per insertion.

    // C#8 Ranges: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges

    var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

    var range = arr[3..^1];

    Dump(range);    // 3456
    Dump(arr[..]);  // 01234567
    Dump(arr[..3]); // 012
    Dump(arr[3..]); // 34567

    Console.ReadKey();
  }

  static void Dump(int[] arr)
  {
    foreach (var i in arr)
    {
      Console.Write(i);
    }

    Console.Write("\n");
  }
}