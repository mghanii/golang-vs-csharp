using System;

class Person
{
  // Field
  private string _name;

  // Properties
  public string Name
  {
    set
    {
      _name = value;
    }
    get
    {
      return _name;
    }
  }

  // Auto property
  public DateTime Birthdate { get; set; }

  // Constructors

  // Default constructor used to initialize fields to thier default values
  public Person()
  {
  }

  public Person(string name)
  {
    this.Name = name;
  }

  // Constructor chaining
  public Person(string name, DateTime birthdate)
      : this(name)
  {
    this.Birthdate = birthdate;
  }

  // Method
  public int GetAge()
  {
    // ⚡ This is not a correct way to calculate age from birthdate
    return DateTime.Today.Year - Birthdate.Year;
  }
}

class Program
{
  static void Main(string[] args)
  {
    // Creating new instance of Person class

    // using parameterless constructor
    var p = new Person();

    Console.WriteLine(p.Name);      // null
    Console.WriteLine(p.Birthdate); // 1/1/0001 12:00:00 AM

    // using parameterized constructors

    var p2 = new Person("Adam");
    Console.WriteLine(p2.Name);      // Adam

    var p3 = new Person("Isaac", DateTime.Parse("02/20/2000"));
    Console.WriteLine(p3.Name);      // Isaac
    Console.WriteLine(p3.GetAge());

    var p4 = p3; // p4 & p3 points to the same object
    p4.Name = "Mohamed";
    Console.WriteLine(p3.Name);      // Mohamed

    Console.ReadKey();
  }
}