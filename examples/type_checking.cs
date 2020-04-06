using System;

class Shape { }

class Circle : Shape { }

class Program
{
  static void Main(string[] args)
  {
    // 1. typeof: returns System.Type instance for a type, resolved at compile time.
    // 2. GetType: returns runtime type of an instance.
    // 3. is: returns true if instance is of the same type as given type or drives from it.

    Shape s = new Shape();
    Shape c = new Circle();

    Console.WriteLine(s is Shape);                       // true
    Console.WriteLine(s is Circle);                      // false

    Console.WriteLine(c.GetType() == typeof(Shape));     // false
    Console.WriteLine(c is Shape);                       // true
    Console.WriteLine(c.GetType() == typeof(Circle));    // true
    Console.WriteLine(c is Circle);                      // true

    Console.ReadKey();
  }
}