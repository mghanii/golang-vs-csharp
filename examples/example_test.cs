using NUnit.Framework;

class Example
{
  public static int Sum(int a, int b) => a + b;
}

class ExampleTests
{
  [TestCase(2, 4, ExpectedResult = 6, TestName = "2+4")]
  [TestCase(-1, 1, ExpectedResult = 0, TestName = "-1+1")]
  [TestCase(-5, 3, ExpectedResult = -2, TestName = "-5+3")]
  public int SumTest(int a, int b)
  {
    return Example.Sum(a, b);
  }
}