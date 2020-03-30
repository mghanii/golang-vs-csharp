using System;

internal class Base
{
  public virtual void SomeMethod() => Console.WriteLine("I am Base");
}

internal class DerivedA : Base
{
  // this method overrides Base's SomeMethod implementation.
  public override void SomeMethod() => Console.WriteLine("I am Derived_A");
}

internal class DerivedB : DerivedA
{
  public new void SomeMethod() => Console.WriteLine("I am Derived_B");
}

internal class Program
{
  private static void Main(string[] args)
  {
    Base baseObj = new Base();
    Base ba = new DerivedA();
    Base bb = new DerivedB();
    DerivedB b = new DerivedB();

    baseObj.SomeMethod();
    ba.SomeMethod();
    bb.SomeMethod();
    b.SomeMethod();

    Console.ReadKey();
  }
}