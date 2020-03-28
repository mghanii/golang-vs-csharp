using System;

class Program
{
  static void Main(string[] args)
  {
    var arr = new int[] { 1, 2, 3, 4, 5 };

    // different ways for using for to print array elements

    for (var i = 0; i < arr.Length; i++)
    {
      Console.Write(arr[i]);
    }

    Console.Write("\n");

    var j = 0;

    for (; j < arr.Length;)
    {
      Console.Write(arr[j]);
      j++;
    }

    Console.Write("\n");

    var k = 0;

    for (; ; )
    {
      if (k >= arr.Length)
        break;

      Console.Write(arr[k]);
      k++;
    }

    Console.Write("\nodd numbers:");

    // print odd numbers in array
    for (var m = 0; m < arr.Length; m++)
    {
      if (arr[m] % 2 == 0)
        continue;

      Console.Write(arr[m]);
    }
    Console.Write("\n");

    // foreach iterates over any collection that implements IEnumerable
    foreach (var item in arr)
    {
      Console.Write(item);
    }

    Console.ReadKey();
  }
}