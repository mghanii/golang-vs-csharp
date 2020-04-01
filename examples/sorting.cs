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
    // sort by age then name
    var result = Age.CompareTo(other.Age);
    if (result == 0) result = Name.CompareTo(other.Name);
    return result;
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

    // Sort composite objects
    var arr4 = new[]{
            new Cat("Max",4),
            new Cat("Max",3),
            new Cat("Angel",1),
            new Cat("Kitty",3),
        };
    Array.Sort(arr4); // sort by name then age
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