using System;

class Circle { }

class Program
{
  static void Main(string[] args)
  {
    var circle = new Circle();

    object obj = circle; // implicit conversion

    // Reference type conversion using is
    if (obj is Circle c)
    {
      Console.WriteLine("obj is Circle");
    }

    Circle c2 = (Circle)obj; // explicit conversion

    var s = "12";
    var a = int.Parse(s);
    var b = Convert.ToInt32(s);

    float d = 4.6F;
    double e = d; // implicit cast
    int f = (int)e; // explicit caset

    Console.WriteLine(f);

    decimal g = (decimal)d;

    Console.ReadKey();
  }
}