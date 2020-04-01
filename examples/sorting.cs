using System;
using System.Linq;

class Cat : IComparable<Cat>
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Cat(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public override string ToString() => $"{Name}-{Age} ";

  public int CompareTo(Cat other)
  {
    // sort by age
    return Age.CompareTo(other.Age);
  }
}

static class Program
{
  static void Main(string[] args)
  {
    // Sort array in ascending order
    var arr1 = new[] { 5, 2, 9, -2, 0, 4 };
    Array.Sort(arr1);
    arr1.Dump();

    // Sort array in descending order
    var arr2 = new[] { 5, 2, 9, -2, 0, 4 };
    Array.Sort(arr2, (v1, v2) => v2 - v1);
    arr2.Dump();

    // Sort using LINQ
    var arr3 = new[] { "D", "A", "E", "B", "C" };
    arr3 = arr3.OrderBy(v => v).ToArray();
    arr3.Dump();

    // Sort custom objects
    var arr4 = new[]{
            new Cat("Max",4),
            new Cat("Kitty",2),
            new Cat("Max",1)
        };
    Array.Sort(arr4);
    arr4.Dump();

    Console.ReadKey();
  }

  static void Dump<T>(this T[] arr)
  {
    foreach (var v in arr)
      Console.Write(v + " ");

    Console.Write("\n");
  }
}