using System;

[AttributeUsage(AttributeTargets.Property)]
class StringLengthAttribute : Attribute
{
  public int MinLength { get; }
  public int MaxLength { get; }

  public StringLengthAttribute(int minLength, int maxLength)
  {
    MinLength = minLength;
    MaxLength = maxLength;
  }
}

class Person
{
  [StringLength(minLength: 3, maxLength: 50)]
  public string Name { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    var propertyInfos = typeof(Person).GetProperties();

    foreach (var p in propertyInfos)
    {
      var att = (StringLengthAttribute)Attribute.GetCustomAttribute(p, typeof(StringLengthAttribute));
      if (att != null)
      {
        Console.WriteLine($"The max length for the {p} property is: {att.MaxLength}");
        Console.WriteLine($"The min length for the {p} property is: {att.MinLength}");
      }
    }
  }
}