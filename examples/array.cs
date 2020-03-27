using System;

class Program
{
  static void Main(string[] args)
  {
    // 📝 An array represents a fixed number of elements of a single type.

    int[] a = new int[5]; // initializes a 5 elements array with 0 defualt element value

    // checks array length
    Console.WriteLine(a.Length); // 5

    a[0] = 4;

    // array initialization expression:

    int[] b = new int[] { 1, 2, 3, 4, 5 };

    // array is a reference type:

    var a1 = new int[] { 1, 2, 3 };
    var a2 = a1; // a2 & a1 are references to the same array object.

    a2[1] = 5;

    for (int i = 0; i < a1.Length; i++)
      Console.Write(a1[i]); // 153

    // multidimensional arrays

    // two dimensional array of 4 rows and 3 columns.
    int[,] array2D = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

    Console.ReadKey();
  }
}