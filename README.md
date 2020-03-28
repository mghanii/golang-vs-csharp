<h3 align="center">
  <br />
  <img src="https://user-images.githubusercontent.com/10288224/77723610-a391c280-6ff9-11ea-92af-19f5d7a2de9c.png" alt="go vs c#" />
  <br />
  <br />
</h3>

# Golang vs C&#35;

This tutorial is intended to help developers learn Go coming from a C# development background and vice versa.

## Contents

- [Comments](#Comments)
- [Variables](#Variables)
- [Types](#Types)
  - [String](#string)
  - [Array](#array)
  - [Slice](#Slice)
  - [Dictionary vs map](#Dictionary-vs-map)
  - [Class](#Class)
  - [Struct](#Struct)
  - [Interface](#interface)

### Comments

---

#### C&#35;

```cs
using System;

namespace Comments
{
  class Program
  {

    /// <summary>
    ///  Application entry point.  👈 this is an XML Documentation Comment
    /// </summary>
    static void Main(string[] args)
    {
      Console.WriteLine("Comments in C#");

      // Single line comment

      /* multiline
         comment
         in C#
      */

    }
  }
}
```

#### Go

```go
package main

import "fmt"

func main() {
	fmt.Println("Comments in Go")

	// Line comment

	/*  General
		   	or
			multiline
	    comment
	*/
}

```

### Variables

---

A variable is a storage location for holding a value.

#### C&#35;

```cs
using System;

class Program
{
    private static void Main(string[] args)
    {
        // explicit
        int a = 9;

        // implicit
        var b = 9;

        // multiple variables declaration at once
        int c, d, e;
        int x = 1, y = 2, z = 3;

        // Constant (unchangeable and read-only)
        const int i = 7;

        // 📝 Local variables can't be used before assigning them.
        // 📝 Constant variable must be assiged a value at the time of its declaration
    }
}
```

#### Go

```go
package main

import "fmt"

func main() {

	// Uninitialized variables are zero-valued
	var a int
	fmt.Println(a) // 0

	var b interface{}
	fmt.Println(b) // nil

	// type is explicitly defined
	var c int = 9

	// type inferred
	var d = true

	// shorthand
	e := "str"

	// multiple variables declaration at once
	var f, g, h int

	// Constant (unchangeable and read-only)
	const i int = 7

	//📝 constant variable must be assiged a value at the time of its declaration

	// all declared variables inside main() must be used
	fmt.Println(c, d, e, f, g, h, i) // 9 true str 0 0 0 7

}
```

### Types

---

A type defines the blueprint for a value.

#### C&#35;

```cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Types in C#");

        /*
       ♦♦ Predefined types ♦♦
          1. Value types: Numeric, bool, char
          2. Reference types: object , string
      */

        // ♦♦ Numeric types ♦♦

        // Signed integer
        sbyte a = -4;  // 8 bits  –27 to 27–1
        short b = 4;   // 16 bits –215 to 215–1
        int c = 4;     // 32 bits –231 to 231–1
        long d = 4;    // var d = 4L;  64 bits –263 to 263–1

        // Unsigned integer
        byte e = 4;    // 8 bits 0 to 28–1
        ushort f = 4;  // 16 bits 0 to 216–1
        uint g = 4;    // var g = 4U;    32 bits 0 to 232–1
        ulong h = 4;   // var h = 4UL;   64 bits 0 to 264–1

        //Real number
        float j = 0.4F; // 32 bits ± (~10–45 to 1038)
        double k = 4D;  // 64 bits ± (~10–324 to 10308)
        decimal l = 4.0M; // 128 bits ± (~10–28 to 1028)

        var m = 4;   // m is int
        var n = 4.0; // n is double

        // ♦♦ Boolean type ♦♦

        bool o = true;

        // ♦♦ Character type ♦♦

        char p = 'A';

        // ♦♦ String type ♦♦

        string s = "str";

        // ♦♦ Array type ♦♦

        char[] alphabet = new char[26];

        // ♦♦ Object type ♦♦
        // 📝 object is the base class for all types so any type can be upcast to object.

        object obj = 4;

        // composite types

        // ♦ class
        // ♦ struct
        // ♦ interface
        // ♦ enum
    }
}
```

#### Go

```go
package main

import "fmt"

func main() {
	fmt.Println("Types in Go")

	// ♦♦ Boolean types ♦♦

	var a bool = true

	// ♦♦ Numeric types ♦♦

	var b uint8 = 4  // 8-bit integers (0 to 255)
	var c uint16 = 4 // 16-bit integers (0 to 65535)
	var d uint32 = 4 // 32-bit integers (0 to 4294967295)
	var e uint64 = 4 // 64-bit integers (0 to 18446744073709551615)

	var f int8 = 4  // 8-bit integers (-128 to 127)
	var g int16 = 4 // 16-bit integers (-32768 to 32767)
	var h int32 = 4 // 32-bit integers (-2147483648 to 2147483647)
	var i int64 = 4 // 64-bit integers (-9223372036854775808 to 9223372036854775807)

	var j float32 = 4.0 // IEEE-754 32-bit floating-point numbers
	var k float64 = 4.0 // IEEE-754 64-bit floating-point numbers

	var l complex64 = 3 + 4i  // float32 real and imaginary parts
	var m complex128 = 3 + 4i // float64 real and imaginary parts

	var n byte = 4   //   alias for uint8
	var o rune = 'k' //    alias for int32

	var p uint = 4 // either 32 or 64 bits depending on the underlying platform
	var q int = 4  // either 32 or 64 bits depending on the underlying platform

	// ♦♦ String types ♦♦

	var s string = "str"
	var length int = len(s) // length of s

	// ♦♦ Array types ♦♦
	// 📝 An array is a numbered sequence of elements of a single type
	var r [3]byte = [3]byte{1, 2, 3}

	// ♦♦ Slice types ♦♦
        // 📝 A slice is a descriptor for a contiguous segment of an underlying array
        //     and provides access to a numbered sequence of elements from that array.

	var t []byte = []byte{1, 2, 3}

	// ♦♦ Struct types ♦♦
        // 📝 A struct is a sequence of named elements, called fields,
        //     each of which has a name and a type.

	var v struct{} = struct{}{} // An empty struct.

	var u struct {
		x int
		y int
	} = struct{ x, y int }{3, 4} // A struct with 2 fields.

	// ♦♦ Pointer types ♦♦

	var w *int = new(int)
	var x *int = &q

	// ♦♦ Function types ♦♦

	var fun func() = func() {}

	// ♦♦ Interface types ♦♦

	var z interface{} // z is nil

	// ♦♦ Map types ♦♦

	var mp map[string]int = map[string]int{}

	// ♦♦ Channel types ♦♦

	var ch chan int = make(chan int)

}
```

### string

#### C&#35;

```cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // 📝 string represents an immutable sequence of Unicode characters.

        var s = "str";

        var length = s.Length; // gets length of s

        var s1 = "Foo";
        var s2 = "Foo";

        // string is a reference type, but follows value-type semantics

        Console.WriteLine(s1 == s2); // True

        // escape sequences:

        Console.WriteLine("C:\\Users");   // C:\Users
        Console.WriteLine("\"Foo\"");     // "Foo"

        // verbatim string literal:
        Console.WriteLine(@"C:\Users");   // C:\Users

        // string concatenation:

        // 1. using + operator

        var s1s2 = s1 + s2;

        // 2. using System.String's Concat method

        Console.WriteLine(System.String.Concat(s1, s2)); // Concat defined in System.String class

        // 3. using System.Text.StringBuilder, useful when you need to concatenate strings many times

        // String interpolation:

        var day = 27;
        var month = 3;
        var year = 2020;

        Console.WriteLine($"date: {day}/{month}/{year}"); // date: 27/3/2020

        var y = 7.12345;
        Console.WriteLine($"{y:F3}"); // 7.123

        Console.ReadKey();
    }
}
```

#### Go

```go
package main

import (
	"fmt"
	"strings"
)

func main() {

	// string is:
	// ♦ Immutable: once created, it is impossible to change its contents.
	// ♦ Represented as a collection of UTF-8 characters.

	var s string = "foo"

	var r byte = s[1]

	fmt.Println(r)         // 111 (ascii code for o)
	fmt.Println(string(r)) // o

	// length of s
	fmt.Println(len(s)) // 3

	// strings package defines many string functions such as:

	fmt.Println(strings.Contains(s, "fo"))                   // true
	fmt.Println(strings.ToUpper(s))                          // FOO
	fmt.Println(strings.Repeat("A", 5))                      // AAAAA
	fmt.Println(strings.Split("a-e-i-o-u", "-"))             // [a e i o u]
	fmt.Println(strings.Replace("PreFix", "Pre", "Post", 1)) // PostFix
	fmt.Println(strings.Index(s, "o"))                       // 1

	// string concatenation:

	s1 := "Foo"
	s2 := "Bar"

	// 1: using Builder which minimizes memory copying
	var b strings.Builder
	b.WriteString(s1)
	b.WriteString(s2)

	fmt.Println(b.String()) // FooBar

	// 2: Join method (uses Builder)
	fmt.Println(strings.Join([]string{s1, s2}, "")) // FooBar

	// 3: using + operator
	fmt.Println(s1 + s2) // FooBar

	s1 += s2
	fmt.Println(s1) // FooBar

	// String interpolation:

	day := 27
	month := 3
	year := 2020

	date := fmt.Sprintf("%d/%d/%d", day, month, year)
	fmt.Println(date) // 27/3/2020

}
```

### array

#### C&#35;

```cs
using System;

class Program
{
  static void Main(string[] args)
  {
    // 📝 An array represents a fixed number of elements of a single type.

    int[] a = new int[5]; // initializes a 5 elements array with 0 defualt element value

    // checks array length
    Console.WriteLine(a.Length); // 5

    a[0] = 4;

    // array initialization expression:

    int[] b = new int[] { 1, 2, 3, 4, 5 };

    // array is a reference type:

    var a1 = new int[] { 1, 2, 3 };
    var a2 = a1; // a2 & a1 are references to the same array object.

    a2[1] = 5;

    for (int i = 0; i < a1.Length; i++)
      Console.Write(a1[i]); // 153

    // multidimensional arrays

    // two dimensional array of 4 rows and 3 columns.
    int[,] array2D = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

    Console.ReadKey();
  }
}
```

#### Go

```go
package main

import (
	"fmt"
)

func main() {

	var a [5]int
	fmt.Println(a) // [0 0 0 0 0]

	// checks array length
	fmt.Println(len(a)) // 5

	// update or get element by index
	a[0] = 4

	// initializer syntax
	a1 := [3]int{1, 2, 3} // this is equivalent to 	a1 := [...]int{1, 2, 3}

	a2 := a1 // a2 is assgined to a copy of a1 contents

	a2[1] = 5

	fmt.Println(a1) // [1 2 3]
	fmt.Println(a2) // [1 5 3]

	var a3 *[3]int = &a1 // a3 & a1  points to the same data
	a3[1] = 7

	fmt.Println(a1)  // [1 7 3]
	fmt.Println(*a3) // [1 7 3]

	// multidimensional arrays

	// two dimensional array of 4 rows and 3 columns.
	var array2D [4][3]int
	n := 1
	for i := 0; i < 4; i++ {
		for j := 0; j < 3; j++ {
			array2D[i][j] = n
			n++
		}
	}

	fmt.Println(array2D) // [[1 2 3] [4 5 6] [7 8 9] [10 11 12]]
}
```

### Slice

#### C&#35;

C# doesn't have an equivalent type to golang's slice type.

However, System.Collections.Generic.List<T> is the most similar collection to slice:<br/>

♦ List is implemented using an underlying array.<br/>
♦ Its size is dynamically resized.<br/>
♦ Has O(1) amortized time per insertion.

```cs
using System;

class Program
{
  static void Main(string[] args)
  {
    // C#8 Ranges: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges

    var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

    var range = arr[3..^1];

    Dump(range);    // 3456
    Dump(arr[..]);  // 01234567
    Dump(arr[..3]); // 012
    Dump(arr[3..]); // 34567

    Console.ReadKey();
  }

  static void Dump(int[] arr)
  {
    foreach (var i in arr)
    {
      Console.Write(i);
    }

    Console.Write("\n");
  }
}
```

#### Go

```go
package main

import "fmt"

func main() {

	// 📝 Slice: a descriptor for a contiguous segment of an underlying array
	// its size is dynamically resized.

	a := []int{} // declare a new slice object

	// len(a) function returns slice length (how many items are in the slice)
	fmt.Println(len(a)) // 0

	// cap(a) returns slice total capacity (size of underlying array)
	fmt.Println(cap(a)) // 0

	a = append(a, 1)
	a = append(a, 2)

	fmt.Println(len(a)) // 2
	fmt.Println(cap(a)) // 2

	a = append(a, 3)

	fmt.Println(len(a)) // 3
	fmt.Println(cap(a)) // 4

	a = append(a, 4)
	a = append(a, 5)

	fmt.Println(len(a)) // 5
	fmt.Println(cap(a)) // 8

	/*
		♦ If length becomes equal to capacity then the capacity of the slice
				 increases automatically by reallocating the internal array.
		♦ The size of newly allocated array will be double the size of old one
		 (if len is < 1024).
		♦ In the example above, capacity grows from
		          0 (initial capacity) -> 1 -> 2 -> 4 -> 8
		       or 1 -> 2 -> 4 -> 8 ... n
		♦ Since n + n/2 + n/4 + ...+ 1 = 2n, the amortized time per insertion is O(1)
		     because n insertions take O(n) time.
	*/

	// It's recommened to create slice using make() if size is known beforehand

	size := 5
	s := make([]int, size)

	for i := 0; i < size; i++ {
		s[i] = i
	}

	fmt.Println(s) // [0 1 2 3 4]

	s1 := []int{1, 2, 3}
	s2 := s1 // s2 & s1 points to the same underlying data

	s2[1] = 9

	fmt.Println(s1) // [1 9 3]
	fmt.Println(s2) // [1 9 3]

	// Slicing: constructing a slice from array, slice or string
	//  a[low : high],  low index is inclusive while high is exclusive

	fmt.Println(s1[:])   // [1 9 3]
	fmt.Println(s1[0:2]) // [1 9]
	fmt.Println(s1[:2])  // [1 9]
	fmt.Println(s1[1:])  // [9 3]

	fmt.Println("test"[1:]) // est

}

```

### Dictionary-vs-map

#### C&#35; (Dictionary)

```cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // C# generic Dictionary defined in  System.Collections.Generic namespace
        // It uses a hashtable data structure to store keys and values.

        var colors = new Dictionary<string, string>
        {
             {"White","#FFFFFF" }
            ,{"Red","#FF0000" }
            ,{"Green","#0000FF" }
            ,{"Blue","#008000" }
        };

        Console.WriteLine(colors["Red"]); // #FF0000

        // update value of existing key
        colors["White"] = "#FFF";

        // iterate over dictionary

        foreach (var kv in colors)
        {
            Console.WriteLine($"Code of {kv.Key} is {kv.Value}");
        }

        // check if key is exist

        if (!colors.ContainsKey("Yellow"))
        {
            // adds new key/value pair
            colors.Add("Yellow", "#FFEF00"); // or colors["Yellow"] = "#FFEF00";
        }

        if (!colors.TryGetValue("Yellow", out var _))
        {
            colors.Add("Yellow", "#FFEF00");
        }

        // TryAdd does nothing if key already exist
        if (!colors.TryAdd("Yellow", "#FFEF00"))
        {
            Console.WriteLine("key already exists");
        }
    }
}
```

#### Go (Map)

```go
package main

import "fmt"

func main() {

	// Initializes an empty map
	m := map[string]int{}

	m["key1"] = 10
	m["key2"] = 20
	m["key3"] = 30

	fmt.Println(m) // map[key1:10 key2:20 key3:30]

	// Deletes key from map
	delete(m, "key2")
	fmt.Println(m) // map[key1:10 key3:30]

	// Update value of existing key
	m["key1"] = 50
	fmt.Println(m) // map[key1:50 key3:30]

	// Iterate over a map
	for key, value := range m {
		fmt.Println(key, value)
	}

	// Checks if key exists
	if value, ok := m["key1"]; ok {
		fmt.Println(value) // 50
	}

	// Initializes a map with initial allocation
	m2 := make(map[string]int, 10)
	_ = m2

	// Initializes a map using map literals
	colors := map[string]string{
		"White": "#FFFFFF",
		"Red":   "#FF0000",
		"Green": "#0000FF",
		"Blue":  "#008000",
	}

	fmt.Println(colors) // map[Blue:#008000 Green:#0000FF Red:#FF0000 White:#FFFFFF]
}
```

### Class

A class is a user-defined blueprint or prototype from which objects are created.

#### C&#35;

Class type is a reference type.

```cs
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
```

#### Go

Go does not have classes.

### Struct

#### C&#35;

Struct (or structure) is a value type, useful to hold small data values.

```cs
using System;

struct Point
{
  public int X { get; }
  public int Y { get; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public override string ToString() => $"({X}, {Y})";
}

class Program
{
  static void Main(string[] args)
  {
    // Struct instantiation:

    var p = new Point(5, 7);

    Console.WriteLine(p.ToString()); // (5, 7)

    var p2 = p; // p2 is a copy of p

    Console.ReadKey();
  }
}
```

#### Go

Struct in Go is a sequence of fields.

```go
package main

import "fmt"

type Person struct {
	name string
	age  int
}

func (p *Person) printAge() {
	fmt.Printf("%v is %v years old\n", p.name, p.age)
}

func main() {

	// Creating a new struct
	p := Person{
		name: "Adam",
		age:  20,
	}

	fmt.Println(p)      // {Adam 20}
	fmt.Println(p.name) // Adam

	p2 := p // p2 is copy of p
	p2.name = "Isaac"
	fmt.Println(p)  // {Adam 20}
	fmt.Println(p2) //{Isaac 20}

	// & prefix yields a pointer to the struct
	p3 := &p // p3 & p poins to the same object
	p3.name = "Mohamed"
	fmt.Println(p)   // {Mohamed 20}
	fmt.Println(*p3) // {Mohamed 20}

	p.printAge() // Mohamed is 20 years old

	// Anonymous struct
	p4 := struct {
		name string
		age  int
	}{
		name: "Nora",
		age:  30,
	}

	fmt.Println(p4) // {Nora 30}

	// Structs are mutable
	p4.age = 50
	fmt.Println(p4) // {Nora 50}
}

```

### Interface

#### C&#35;

- Interface defines a contract.
- A class or a struct can implement multiple interfaces.
- Beginning with C# 8.0, interface can provide a default implementation for members.

```cs
using System;

public interface IShape
{
  double GetArea();
}

public interface IDrawable
{
  void Draw();
}

public struct Point
{
  public int X { get; }
  public int Y { get; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }
}

public class Square : IShape
{
  public double Side { get; set; }

  public Square(double side) => Side = side;

  public double GetArea() => Side * Side;
}

// Multiple interface implementations
public class Circle : IShape, IDrawable
{
  public Circle(Point center, double radius)
  {
    Center = center;
    Radius = radius;
  }

  public Point Center { get; set; }
  public double Radius { get; set; }

  public double GetArea() => Math.PI * Radius * Radius;

  public void Draw() => Console.WriteLine("Drawing Circle");
}

internal class Program
{
  private static void PrintArea(IShape shape)
  {
    Console.WriteLine(shape.GetArea());
  }

  private static void Main(string[] args)
  {
    var square = new Square(4);
    PrintArea(square); // 16

    var circle = new Circle(new Point(3, 6), 7);
    PrintArea(circle); // 153.93804002589985

    Console.ReadKey();
  }
}
```

#### Go

- Interfaces are implemented implicitly.
- If a type implements a method with name and signature defined in an interface, then that type implements that interface.

```go
package main

import (
	"fmt"
	"math"
)

type Drawable interface {
	draw()
}

type Shape interface {
	getArea() float64
}

type Point struct {
	X, Y int
}

type Square struct {
	side float64
}

type Circle struct {
	center Point
	radius float64
}

// This method means type Circle implements the interface Shape
func (c Circle) getArea() float64 {
	return math.Pi * c.radius * c.radius
}

func (c Circle) draw() {
	fmt.Println("Drawing circle")
}

func (s Square) getArea() float64 {
	return s.side * s.side
}

func printArea(s Shape) {
	fmt.Println(s.getArea())
}

func main() {
	s := Square{side: 4}
	c := Circle{Point{3, 6}, 7}

	// Since both Square & Circle implement Shape interface, we can do the following:
	printArea(s) // 16
	printArea(c) // 153.93804002589985

	var d Drawable = c
	d.draw() // Drawing circle
}
```
