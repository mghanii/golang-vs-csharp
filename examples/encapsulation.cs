public class A // A is accessed by code from any assembly.
{
  // _field1 is accessible only within A class ( fields are private by default).
  int _field1;

  protected internal int _field2;

  protected virtual void MethodA() => _; // accessible only within A or B classes
}

class B : A // B is internal (class by default is internal)
{
  protected void MethodB()
  {
    base._field1; // error: can't access _field1
    base.MethodA();
  }
}

// if C is defined in a different assembly than A's assembly, it must subclass A to access _field2
internal class C
{
  public C()
  {
    var a = new A();
    var x = a._field2;
    a.MethodA(); // error: can't access MethodA
  }
}