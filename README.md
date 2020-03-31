<h3 align="center">
  <br />
  <img src="https://user-images.githubusercontent.com/10288224/77723610-a391c280-6ff9-11ea-92af-19f5d7a2de9c.png" alt="go vs c#" />
  <br />
  <br />
</h3>

# Golang vs C&#35;

This tutorial is intended to help developers learn Go coming from a C# development background and vice versa.

Code examples are availaleble in [examples/](examples/)

## Contents

- [Comments](#comments)
- [Variables](#variables)
- [Types](#Types)
  - [String](#string)
  - [Array](#array)
  - [Slice](#Slice)
  - [Dictionary (C#)](#Dictionary-vs-map)
  - [Map(Go)](#gomap)
  - [Class](#Class)
  - [Struct](#Struct)
  - [Interface](#interface)
- [Object vs interface{}](#objectinterface)
  - [object(C#)](#objectinterface)
  - [interface{}(Go)](#goemptyinterface)
- [Type checking](#typechecking)
- [Type conversion](#typeconversion)
- [Functions](#functions)
  - [Methods](#functions)
  - [Overloading](#functions)
  - [Multiple return values](#functions)
  - [Default parameters](#functions)
  - [Anonymous functions](#functions)
- [If](#if)
- [Switch](#switch)
- [For](#for)
  - [foreach (C#)](#for)
  - [for range (Go)](#gofor)
- [While](#while)
- [Closures](#Closures)
- [Error handling](#errorhandling)
  - [try/catch (C#)](#errorhandling)
  - [exceptions (C#)](#errorhandling)
  - [errors](#goerrors)
- [throw / panic](#throwpanic)
- [Clean-up](#cleanup)
  - [finally](#cleanup)
  - [defer](#gocleanup)
- [Inheritance](#inheritance)
- [Polymorphism](#polymorphism)
- [Pointers](#pointers)
- [Concurrency](#concurrency)
  - [async/await(C#)](#concurrency)
  - [goroutines/channels(Go)](#goconcurrency)

<h3 id=comments>🔶 Comments</h3>

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

<h3 id=variables>🔶 Variables</h3>

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

#### Go: variables

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

<h3 id=types>🔶 Types</h3>

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

#### Go: types

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

---

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

#### Go: string

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

---

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

#### Go: array

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

---

#### C&#35;

C# doesn't have an equivalent type to golang's slice type.

However, System.Collections.Generic.List<T> is the most similar collection to slice:<br/>

- List is implemented using an underlying array.
- Its size is dynamically resized.
- Has O(1) amortized time per insertion.

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

#### Go: slice

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

### Dictionary vs map

---

#### C&#35;: Dictionary

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

<h4 id=gomap>Go: Map</h4>

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

---

📝 A class is a user-defined blueprint or prototype from which objects are created.

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

---

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

#### Go: struct

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

---

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

#### Go: interface

- Used to group related sets of methods.
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
	Area() float64
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
func (c Circle) Area() float64 {
	return math.Pi * c.radius * c.radius
}

func (c Circle) draw() {
	fmt.Println("Drawing circle")
}

func (s Square) Area() float64 {
	return s.side * s.side
}

func printArea(s Shape) {
	fmt.Println(s.Area())
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

<h3 id=objectinterface>🔶 Object vs interface{}</h3>

---

#### C&#35;

Every type in C# derives from object class, so a variable of type object can point to data of any type.

```cs
 object[] arr = new object[]
    {
            44,
            4.5,
            "string",
            DateTime.Now,
            true,
            new int[]{1,2,3}
    };
```

<h3 id=goemptyinterface>Go: interface{}</h3>

- Empty interface is just an interface defined on the fly that has no methods on it.

- Every type in Go implements the empty interface, so a variable of type interface{} can store data of any type.

```go
package main

import (
	"fmt"
	"reflect"
	"time"
)

func main() {

	arr := []interface{}{
		44,
		4.5,
		"string",
		time.Now(),
		true,
		'a',
		[]int{1, 2, 3},
	}
	for _, v := range arr {
		fmt.Println(reflect.TypeOf(v))
	}

}
```

<h3 id=typechecking>🔶 Type checking</h3>

---

#### C&#35;

```cs
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
```

#### Go: type checking

```go
package main

import (
	"fmt"
	"reflect"
)

func main() {

	var a int64 = 4

	fmt.Println(reflect.TypeOf(a).Kind() == reflect.Int64)

	var b interface{} = 4

	if _, isInt := b.(int); isInt {
		fmt.Println("i is int")
	}

}
```

output

```bash
true
i is int
```

<h3 id=typeconversion>🔶 Type conversion</h3>

---

#### C&#35;

```cs
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
```

output

```bash
obj is Circle
4
```

#### Go: type conversion

```go
package main

import (
	"fmt"
	"strconv"
)

func main() {

	var a int = 20
	b := float32(a)
	fmt.Printf("%v, %T\n", b, b)

	d := strconv.Itoa(a)
	fmt.Printf("%v, %T\n", d, d)

	e, err := strconv.Atoi("123")
	if err == nil {
		fmt.Printf("%v, %T\n", e, e)
	}

	g, err := strconv.ParseInt("235", 10, 64)
	if err == nil {
		fmt.Printf("%v, %T\n", g, g)
	}
}
```

output

```bash
20, float32
20, string
123, int
235, int64
```

<h3 id=functions>🔶 Functions</h3>

---

#### C&#35;

- In C# functions declared within a type (class, struct or interface).
- Methods can be instane members or static (related to type rather than instances).
- C# supports method and operator overloading.
- Methods can return multiple values by using Tuple, ref or out.
- Methods can passed around as variables or method arguments.

```cs
using System;

internal class Program
{
  // Overloaded methods
  public static int Sum(int a, int b) => a + b;

  public static int Sum(int a, int b, int c) => a + b + c;

  // Method with a parameter that takes a variable number of arguments
  public static int Multiply(params int[] values)
  {
    var result = 1;

    for (var i = 0; i < values.Length; i++)
    {
      result *= values[i];
    }

    return result;
  }

  // Method with multiple return values
  public static Tuple<string, int, bool> GetValues()
  {
    return Tuple.Create("some value", 1, false);
  }

  // Func is a delegate type which holds a reference to a method
  public static int Transform(Func<int, int> transformer, int value)
  {
    return transformer(value);
  }

  // Optional parameters
  public static int Increment(int value, int step = 1)
  {
    return value + step;
  }

  public static int Square(int value) => value * value;

  private static void Main(string[] args)
  {
    var square = Transform(Square, 3);
    Console.WriteLine(square);       // 9

    // Anonymous method
    square = Transform(delegate (int value) { return value * value; }, 3);
    Console.WriteLine(square);       // 9

    Console.WriteLine(Sum(1, 2));    // 3
    Console.WriteLine(Sum(1, 2, 3)); // 6

    Console.WriteLine(Increment(1));    // 2
    Console.WriteLine(Increment(1, 5)); // 6

    Console.WriteLine(Multiply(1, 2));       // 2
    Console.WriteLine(Multiply(1, 2, 3));    // 6
    Console.WriteLine(Multiply(1, 2, 3, 4)); // 24

    Console.ReadKey();
  }
}
```

#### Go: functions

- Go does not support overloding of methods and operators.
- Go does not support function/method argument default value.
- A Method is a function with a receiver.
- Go supports methods defined on struct types.

```go
package main

import "fmt"

// variadic function: accepts a variable number of arguments
func sum(values ...int) (result int) {

	for _, v := range values {
		result += v
	}

	return // result is a named return value
}

func transform(transformer func(v int) int, value int) int {
	return transformer(value)
}

// multiple return values
func divide(a float32, b float32) (float32, error) {
	if b == 0.0 {
		return 0, fmt.Errorf("Attempted to divide by zero")
	}
	return a / b, nil
}

// Go supports methods defined on struct types.
type user struct {
	name string
}

// value receiver (receives a copy of user instance when called)
func (u user) printName() {
	fmt.Println(u.name)
}

//  pointer receiver (receives a pointer to user instance when called)
func (u *user) printName2() {
	fmt.Println(u.name)
}

func main() {
	fmt.Println(sum(1, 2))    // 3
	fmt.Println(sum(1, 2, 3)) //6

	// Anonymous function
	func(v int) {
		fmt.Println(v) // 4
	}(4)

	// passing func around as variable or parameter
	var square = transform(func(v int) int {
		return v * v
	}, 4)

	fmt.Println(square) // 16

	v, _ := divide(4, 2)
	fmt.Println(v) // 2

	var usr = user{name: "Adam"}

	usr.printName()     // Adam
	(&usr).printName2() // Adam

}

```

<h3 id=if>🔶 If</h3>

---

#### C&#35;

```cs
using System;

class Program
{
  static void Main(string[] args)
  {
    int a = 4;
    int b = 3;
    int min;

    if (a < b) min = a;
    else min = b;

    // above if statment could be rewritten using ternary operator:
    min = a < b ? a : b;

    if (a == 0)
    {
      Console.WriteLine("x is 0");
    }
    else if (a > 0)
    {
      Console.WriteLine("x is positive");
    }
    else
    {
      Console.WriteLine("x is negative");
    }

    Console.ReadKey();
  }
}
```

#### Go: if

```go
package main

import "fmt"

func main() {

	a := 2

	if a < 0 {
		fmt.Println("a is negative")
	} else if a > 0 {
		fmt.Println("a is positive")
	} else {
		fmt.Println("a is 0")
	}

	if b := a + 1; b%2 == 0 {
		fmt.Println("b is even")
	} else {
		fmt.Println("b is odd")

		//  📝 Go doesn't have ternary operator
	}
}
```

output

```bash
a is positive
b is odd
```

<h3 id=switch>🔶 Switch</h3>

---

#### C&#35;

```cs
using System;

class Program
{
  static void Main(string[] args)
  {
    var color = "blue";

    switch (color)
    {
      case "red":
        Console.WriteLine("Red code is #FF0000");
        break;

      case "blue":
        Console.WriteLine("Blue code is #0000FF");
        break;

      default:
        Console.WriteLine("Invalid color");
        break;
    }

    var a = 2;

    switch (a)
    {
      case 1:
      case 2:
      case 3:
        Console.WriteLine("case 1, 2 or 3");
        break;

      case 4:
        Console.WriteLine("case 4");
        break;

      default:
        Console.WriteLine("default case");
        break;
    }

    // Checking for type (C# 7)

    object obj = 4;

    switch (obj)
    {
      case null:
        Console.WriteLine("obj is null");
        break;

      case int v:
        Console.WriteLine("obj is int");
        break;

      case string v:
        Console.WriteLine("obj is string");
        break;

      default:
        Console.WriteLine("obj type is not know");
        break;
    }

    Console.ReadKey();
  }
}
```

output

```bash
Blue code is #0000FF
case 1, 2 or 3
obj is int
```

#### Go: switch

```go
package main

import "fmt"

func f1() {
	fmt.Println("Executing f1...")
}
func f2() {
	fmt.Println("Executing f2...")
}
func f3() {
	fmt.Println("Executing f3...")
}

func main() {

	a := 2

	switch {
	case a == 1:
		f1()
	case a == 2:
		f2()
	default:
		f3()
	}

	b := 10

	switch b {
	case 1, 10, 100:
		f1()
	case 2, 20:
		f2()
	default:
		f3()
	}

	switch c := a - 2; {
	case c < 0:
		fmt.Println("c is negative")
	case c > 0:
		fmt.Println("c is positive")
	default:
		fmt.Println("c is 0")
	}

	// fallthrough: transfers control to the first statement of the next case
	i := 1

	switch i {
	case 1:
		fmt.Println("case 1")
		fallthrough
	case 2:
		fmt.Println("case 2")
	default:
		fmt.Println("default")

	}

	// Type switch: compares types rather than values.

	var d interface{} = 4

	switch d.(type) {
	case int:
		fmt.Println("d is int")
	case float32:
		fmt.Println("d is float32")
	default:
		fmt.Println("type is not known")
	}

	// above switch could be rewritten:

	if _, isInt := d.(int); isInt {
		fmt.Println("d is int")
	} else if _, isFloat32 := d.(float32); isFloat32 {
		fmt.Println("d is float32")
	} else {
		fmt.Println("type is not known")
	}
}
```

output

```bash
Executing f2...
Executing f1...
c is 0
case 1
case 2
d is int
d is int
```

<h3 id=for>🔶 For</h3>

---

#### C&#35;

```cs
using System;

class Program
{
  static void Main(string[] args)
  {
    var arr = new int[] { 1, 2, 3, 4, 5 };

    // different ways for using for to print array elements

    for (var i = 0; i < arr.Length; i++)
    {
      Console.Write(arr[i]);
    }

    Console.Write("\n");

    var j = 0;

    for (; j < arr.Length;)
    {
      Console.Write(arr[j]);
      j++;
    }

    Console.Write("\n");

    var k = 0;

    for (; ; )
    {
      if (k >= arr.Length)
        break;

      Console.Write(arr[k]);
      k++;
    }

    Console.Write("\nodd numbers:");

    // print odd numbers in array
    for (var m = 0; m < arr.Length; m++)
    {
      if (arr[m] % 2 == 0)
        continue;

      Console.Write(arr[m]);
    }
    Console.Write("\n");

    // foreach iterates over any collection that implements IEnumerable
    foreach (var item in arr)
    {
      Console.Write(item);
    }

    Console.ReadKey();
  }
}
```

output

```bash
12345
12345
12345
odd numbers:135
12345
```

<h4 id =gofor>Go: for</h4>

```go
package main

import "fmt"

func main() {

	a := 2

	for a < 40 {
		fmt.Printf("%v ", a)
		a *= 2
	}
	fmt.Printf("\n")

	arr := [...]int{1, 2, 3, 4, 5}

	for i := 0; i < len(arr); i++ {
		fmt.Printf("%v ", arr[i])
	}

	fmt.Printf("\n")

	// for range
	for _, v := range arr {
		fmt.Printf("%v ", v)
	}

	// infinite loop
	for {
		// do stuff
		break // break out of loop
	}

	// break statement terminates execution of the innermost loop
	// to terminate execution of outer loop use lables or functions (return)
outerLoop:
	for m := 0; m < 3; i++ {
		for n := 0; n < 5; n++ {
			if m*n == 12 {
				break outerLoop
			}
		}
	}
}
```

output

```bash
2 4 8 16 32
1 2 3 4 5
1 2 3 4 5
```

 <h3 id=while>🔶 while</h3>

---

#### C&#35;

```cs
    var attempt = 1;

    while (attempt <= 3)
    {
      Console.WriteLine($"attempt # {attempt}");
      // do other stuff
      attempt++;
    }

    // use break to exit
    while (true)
    {
	  // do stuff

      break;
    }

    // do ... while: executed at least 1 time
    do
    {
      Console.WriteLine("do while...");
    } while (false);
```

output

```bash
attempt # 1
attempt # 2
attempt # 3
do while...
```

#### Go: while

Go doesn't have while keyword but same behavior can be achieved using for.

```go
	// we can get same while behavior using for:
	var attempt = 1

	for attempt <= 3 {
		fmt.Printf("attempt # %v\n", attempt)
		// do other stuff
		attempt++
	}
```

output

```bash
attempt # 1
attempt # 2
attempt # 3
```

<h3 id=closures>🔶 Closures</h3>

---

#### C&#35;

- Closure is a lambda expression that references parameters of method they're defined in or its local variables.

- These variables survive as long as closure is accessible.

```cs
  static Func<int> Sequence(int start = 0)
  {
    // Closure captures method parameter
    return () => start++;
  }

  static void Main(string[] args)
  {
    var stepSize = 2;
    Func<int, int> incrementer = value => value + stepSize;
    stepSize = 5;
    Console.WriteLine(incrementer(3)); // 8

    // The lifetime of captured method parameter is extended to that of the capturing delegate (seq)
    var seq = Sequence();
    Console.WriteLine(seq()); // 0
    Console.WriteLine(seq()); // 1
    Console.WriteLine(seq()); // 2

    var seq2 = Sequence();
    Console.WriteLine(seq2()); // 0

    // Capturing iteration variables

    // Below code is intended to print 01234
    var func = new Func<int>[5];
    for (int i = 0; i < 5; i++)
      func[i] = () => i;

    foreach (var f in func)
      Console.Write(f()); // 55555

    // In this example iteration variable "i" is treaded as it's declared outside the for statement.
    // To get the expected result, define a new variable inside the loop, copy the iteration value to that.
    for (int i = 0; i < 5; i++)
    {
      int k = i;
      func[i] = () => k;
    }

    foreach (var f in func)
      Console.Write(f()); // 01234
	}
```

#### Go

- Closure: an anonymous function references an outer variable.

```go
package main

import "fmt"

func sequence() func() int {
	start := 0
	return func() int {
		start++
		return start - 1
	}
}

func main() {

	// Captured variable (start) lifetime is extented to that of the capturing func(), seq.
	seq := sequence()

	fmt.Println(seq()) // 0
	fmt.Println(seq()) // 1
	fmt.Println(seq()) // 2

	seq2 := sequence()
	fmt.Println(seq2()) // 0

	// Capturing iteration variables

	// Below code is intended to print 01234
	// but it prints 55555 because i is captured by anonymous function
	var arr [5]func()

	for i := 0; i < len(arr); i++ {
		arr[i] = func() {
			fmt.Print(i)
		}
	}

	for _, f := range arr {
		f()
	}

	// to get expected result:
	for i := 0; i < len(arr); i++ {
		k := i
		arr[i] = func() {
			fmt.Print(k)
		}
	}

	fmt.Print("\n")

	for _, f := range arr {
		f()
	}
}
```

<h3 id=errorhandling>🔶 Error handling</h3>

---

#### C&#35;

```cs
using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    // All exceptions in c# inherits from System.Exception class

    string filePath = null;
    FileStream stream = null;

    try
    {
      // try block contains the code causing exception

      stream = File.Open(filePath, FileMode.Open);

      //...
    }
    catch (ArgumentException ex) // handles exceptions of type ArgumentException
    {
      Console.WriteLine($"ArgumentException: {ex.Message}");
    }
    catch (Exception ex) // handles any exception
    {
      Console.WriteLine(ex.Message);
    }
    finally
    {
      // will always execute whether an exception is thrown or not.

      if (stream != null)
        stream.Close();
    }
  }
}
```

<h4 id=goerrors>Go: error handling</h4>

```go
package main

import (
	"errors"
	"fmt"
)

func divide(a int, b int) (int, error) {
	if b == 0.0 {
		return 0, fmt.Errorf("Attempted to divide by zero")
	}
	return a / b, nil
}

func main() {
	// Go doesn't handle exceptions as C# does,
	// there is no tryr/catch, instead errors are returned as a method return value.
	// "error" is a built-in interface, which you can implement to create a custom errors .

	a, b := 4, 0

	result, err := divide(a, b)

	if err != nil {
		// handle error
		fmt.Println("Error: ", err)
	} else {
		fmt.Printf("%v / %v = %v", a, b, result)
	}

	// to create an error:
	_ = fmt.Errorf("error message")
	// or
	_ = errors.New("error message")

}
```

output

```bash
Error:  Attempted to divide by zero
```

<h3 id=throwpanic>🔶 throw / panic</h3>

---

#### C&#35;: throw

```cs
 static void Display(string name)
  {
    if (string.IsNullOrEmpty(name))
      throw new ArgumentNullException(nameof(name), "name can't be null or empty");

    Console.WriteLine($"Hello, {name}");
  }

  static void Main(string[] args)
  {
    // throw: rethrows same exception and preserves original stack trace.
    // throw ex: rethrows exception and resets the stack trace.
    try
    {
      var name = Console.ReadLine();
      Display(name);
    }
    catch (Exception ex)
    {
      //  throw;
      //  throw ex;
      Console.WriteLine(ex.Message);
    }
  }
```

#### Go: panic

```go
package main

import (
	"fmt"
)

func divide(a int, b int) int {
	if b == 0.0 {
		// panic is similar to C#'s exceptions, it's a run-time error.
		// panic() function terminates the flow of control and starts panicking.
		panic("Attempted to divide by zero")
	}
	return a / b
}

func main() {
	// recover(): regains control of a panicking goroutine.
	// defer function always run even if the program panics.
	defer func() {
		if x := recover(); x != nil {
			fmt.Println("run time panic: ", x)
		}
	}()

	fmt.Println("main start")
	_ = divide(4, 0)
}
```

<h3 id=cleanup>🔶 Clean up</h3>

---

#### C&#35;

```cs
// "using" statement is used to automatically dispose an object once
//     using statement is exited (by reaching block end or by an exception).
// The objects specified within the using block must implement the IDisposable interface.
// IDisposable interface contains Dispose method which can be invoked when object is no longer needed.

using (var fileStream = File.Open("path/to/file", FileMode.Open))
{
   // ....
}

// this is equivalent to:
FileStream fs = null;

try
{
   fs = File.Open("path/to/file", FileMode.Open);

   // ...
}
finally
{
   if (fs != null)
      fs.Dispose();
}
```

<h4 id=gocleanup>Go: cleanup</h4>

```go
package main

import (
	"fmt"
	"os"
)

func main() {

	file, err := os.Create("/path/to/file")

	if err != nil {
		fmt.Println(err)
	}

	// Defere is used for clean-up activities
	// Deferred function calls are executed in
	// Last In First Out order after the surrounding function returns

	defer file.Close()

	// write to  file
	fmt.Fprintln(file, "test test...")

}
```

<h3 id=inheritance>🔶 Inheritance</h3>

---

- Inheritance is "is a" relationship: Dog is an Animal.
- Method overriding: change the implementation of a function  
   in the derived class that is defined in the base class.
- C# doesn't support multiple inheritance through classes.
- Any class or struct can implement multiple interfaces.
- Structs don't support inheritance.

#### C&#35;

```cs
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
```

output

```bash
I am Base
I am Derived_A
I am Derived_A
I am Derived_B
```

#### Go: inheritance

Go doesn’t support inheritance, but supports struct embed­ding and composition to reuse code.

```go
package main

import "fmt"

type Animal struct {
	name string
	age  int
}

// struct embed­ding
type Dog struct {
	Animal
	breed string
}

// struct composition
type Cat struct {
	pet Animal
}

func (a *Animal) Description() string {
	return fmt.Sprintf("name: %v, age: %v", a.name, a.age)
}

func (a *Animal) Sleep() {
	fmt.Printf("%v is sleeping\n", a.name)
}

func (c *Cat) Sleep() {
	c.pet.Sleep()
}

func main() {
	dog := Dog{Animal: Animal{name: "Max", age: 3}, breed: "Basenji"}
	fmt.Println(dog.Description())
	dog.Sleep()

	cat := Cat{pet: Animal{name: "Kitty", age: 2}}

	fmt.Println(cat.pet.Description())
	cat.Sleep()
}
```

output

```bash
name: Max, age: 3
Max is sleeping
name: Kitty, age: 2
Kitty is sleeping
```

<h3 id='polymorphism'>🔶 Polymorphism</h3>

---

#### C&#35;

- Compile-time or static poly­mor­phism:
  - method/operator overloading.
- Runtime poly­mor­phism:
  - method overriding through inheritance.

> A polymorphic behavior can be achieved by using features like
> variance (covariance and contravariance)

#### Go

A polymorphic behavior can be achieved by using interfaces.

```go
package main

import (
	"fmt"
	"math"
	"reflect"
)

type Shape interface {
	Area() float64
}

type Square struct {
	side float64
}

type Circle struct {
	radius float64
}

func (c Circle) Area() float64 {
	return math.Pi * c.radius * c.radius
}

func (s Square) Area() float64 {
	return s.side * s.side
}

func displayArea(shape Shape) {
	fmt.Printf("area of %v is %v\n", reflect.TypeOf(shape).Name(), shape.Area())
}

func main() {

	shapes := []Shape{Square{3}, Circle{3}}
	for _, v := range shapes {
		displayArea(v)
	}
}
```

output

```bash
area of Square is 9
area of Circle is 28.274333882308138
```

<h3 id=pointers>🔶 Pointers</h3>

---

#### C&#35;

When you pass a variable to a method:

- if it's value type, you pass a copy of variable's value.
- if it's reference type, you pass a copy of reference to the object.
- ref keyword is used to pass variable by reference.

- By default, C# does not support pointer arithmetic.
- Pointers can be used only inside an unsafe context, using unsafe keword.

```cs
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
```

output

```bash
Max
False
True
1
2
5
6
```

#### Go: pointers

- For safety reasons, Go doesn't suport pointer arithmetic.
- You can get around this by using [unsafe](https://pkg.go.dev/unsafe?tab=doc) package

```go
package main

import "fmt"

func valTest(v int) {
	v = 5
}

func pointerTest(v *int) {
	// pointer dereferencing
	*v = 5
}

type Cat struct{ name string }

// value receiver doesn't mutate state
func (c Cat) valReceiverTest() {
	c.name = "Max"
}

// pointer receiver mutates state
func (c *Cat) pointerReceiverTest() {
	c.name = "Max"
}

func main() {

	a := 2

	// passing variables by value copies the value.
	valTest(a)
	fmt.Println(a)

	// &a: address operator, generates a pointer to a
	pointerTest(&a)

	fmt.Println(a)

	c := Cat{name: "Kitty"}
	// passes copy of c to valReceiverTest method
	c.valReceiverTest()
	fmt.Println(c.name)

	// passes address of c to pointerReceiverTest method
	c.pointerReceiverTest()
	fmt.Println(c.name)
}
```

output

```bash
2
5
Kitty
Max
```

<h3 id=concurrency>🔶 Concurrency</h3>

---

#### C&#35;

```cs
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

internal class Program
{
  private class QuoteEntity
  {
    public string Quote { get; set; }
    public string Author { get; set; }
  }

  private static void DisplayQuote(QuoteEntity quote) =>
      Console.WriteLine($"quote: {quote.Quote}\nauthor: {quote.Author}\n");

  private static async Task<QuoteEntity> GetRandomQuoteAsync()
  {
    var path = "http://quotes.stormconsultancy.co.uk/random.json";

    var json = await new HttpClient().GetStringAsync(path);

    return JsonConvert.DeserializeObject<QuoteEntity>(json);
  }

  private static async Task Main(string[] args)
  {
    // Multithreading: using multiple threads.
    // C# has a high-level features that abstracts a way the concept of threads,
    // so mostly, we don't need to create a thread using new keyword.
    var t1 = new Thread(() => Console.WriteLine("Thread 1"));
    t1.Start();
    t1.Join();

    // Asynchronous programming

    var quote = await GetRandomQuoteAsync();
    DisplayQuote(quote);

    var task = Task.Run(GetRandomQuoteAsync);
    quote = await task;
    DisplayQuote(quote);

    // Waiting for many tasks to complete
    var tasks = new Task<QuoteEntity>[] {
            GetRandomQuoteAsync(),
            GetRandomQuoteAsync()
        };

    var quotes = await Task.WhenAll(tasks);

    foreach (var q in quotes)
      DisplayQuote(q);

    Console.ReadKey();
  }
}
```

<h4 id=goconcurrency>Go: concurrency</h4>

- Goroutine is a function that is capable of running concurrently with other functions.
- Channel is a pipeline for sending and receiving data.
- Channels provide a way for one goroutine to send structured data to another.
- By default, Go uses CPU threads equal to available cores.

```go
package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"log"
	"net/http"
	"sync"
)

type Quote struct {
	Quote  string `json:"quote"`
	Author string `json:"author"`
}

func parseBody(r *http.Response, x interface{}) {
	defer r.Body.Close()
	body, err := ioutil.ReadAll(r.Body)
	if err != nil {
		log.Fatal(err)
		return
	}

	if err = json.Unmarshal(body, x); err != nil {
		log.Fatal(err)
	}
}

func getRandomQuote() Quote {
	res, err := http.Get("http://quotes.stormconsultancy.co.uk/random.json")
	if err != nil {
		log.Fatal(err)
	}
	q := Quote{}
	parseBody(res, &q)

	return q
}

func displayQuotes(ch <-chan Quote) {
	for {
		select {
		case quote := <-ch:
			fmt.Printf("%+v\n", quote)
		case <-doneCh:
			break
		}
	}
}

var doneCh = make(chan struct{})

func main() {
	quotesCount := 5
	quotesCh := make(chan Quote, quotesCount)
	wg := sync.WaitGroup{}

	go displayQuotes(quotesCh)

	// get random quotes
	wg.Add(quotesCount)
	for i := 0; i < quotesCount; i++ {
		go func(ch chan<- Quote) {
			defer wg.Done()
			quote := getRandomQuote()
			ch <- quote
		}(quotesCh)
	}

	wg.Wait()
	doneCh <- struct{}{}
}
```
