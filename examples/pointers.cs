using System;

class Cat
{
  public string Name { get; set; }
}

class Program
{
  static void RenameCat(Cat cat) => cat.Name = "Max";

  static void PassReferenceTypeByValueTest(Cat c) => c = null;

  static void PassReferenceTypeByReferenceTest(ref Cat c) => c = null;

  static void PassValueTypeByReferenceTest(ref int n) => n++;

  static void PassValueTypeByValueTest(int n) => n++;

  static void Main(string[] args)
  {
    var cat = new Cat { Name = "Kitty" };

    // passing reference rypes by value: passing a copy of cat reference
    RenameCat(cat);
    Console.WriteLine(cat.Name);

    PassReferenceTypeByValueTest(cat);
    Console.WriteLine(cat is null);

    // Passing reference rypes by reference
    PassReferenceTypeByReferenceTest(ref cat);
    Console.WriteLine(cat is null);

    // value types:

    var a = 1;

    // Passing value types by value
    PassValueTypeByValueTest(a);
    Console.WriteLine(a);

    // Passing value types by reference
    PassValueTypeByReferenceTest(ref a);
    Console.WriteLine(a);

    // Pointers:
    int b = 5;

    // this code won't compile without unsafe option
    unsafe
    {
      int* p = &b;
      Console.WriteLine(*p);

      *p += 1;
      Console.WriteLine(*p);
    }

    Console.ReadKey();
  }
}