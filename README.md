<h3 align="center">
  <br />
  <img src="https://user-images.githubusercontent.com/10288224/77723610-a391c280-6ff9-11ea-92af-19f5d7a2de9c.png" alt="go vs c#" />
  <br />
  <br />
</h3>

## Contents

- [Comments](#Comments)
- [Variables](#Variables)
- [Types](#Types)
  - [string](#string)
  - [array](#array)
  - [List vs slice](#List-vs-slice)
  - [Dictionary vs map](#Dictionary-vs-map)

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

### List-vs-slice

#### C&#35;

C# doesn't have a type equivalent to golang's slice type.

However, System.Collections.Generic.List<T> is the most similar collection to slice:<br/>

♦ List is implemented using an underlying array.<br/>
♦ Its size is dynamically increased.<br/>
♦ Has O(1) amortized time per insertion.

Also C#7.2 introduced [Span&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.span-1?view=netcore-3.1) feature
which references a contiguous memory that has already been allocated.

#### Go

```go
package main

import "fmt"

func main() {

	// 📝 Slice: a descriptor for a contiguous segment of an underlying array
	// its size is incremented dynamically.

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

        // updates value of existing key
        colors["White"] = "#FFF";

        // iterate over dictionary

        foreach (var kv in colors)
        {
            Console.WriteLine($"Code of {kv.Key} is {kv.Value}");
        }

        if (!colors.ContainsKey("Yellow"))
        {
            // adds new key/value pair
            colors.Add("Yellow", "#FFEF00"); // or colors["Yellow"] = "#FFEF00";
        }
    }
}
```

#### Go (Map)

```go
package main

import "fmt"

func main() {

	// declare empty map
	m := map[string]int{} // or make(map[string]int)

	m["key1"] = 10
	m["key2"] = 20
	m["key3"] = 30

	fmt.Println(m) // map[key1:10 key2:20 key3:30]

	delete(m, "key2")
	fmt.Println(m) // map[key1:10 key3:30]

	// update value of existing key
	m["key1"] = 50
	fmt.Println(m) // map[key1:50 key3:30]

	// iterate over map
	for key, value := range m {
		fmt.Println(key, value)
	}

	// check if key exists

	if value, ok := m["key1"]; ok {
		fmt.Println(value) // 50
	}

	colors := map[string]string{
		"White": "#FFFFFF",
		"Red":   "#FF0000",
		"Green": "#0000FF",
		"Blue":  "#008000",
	}

	fmt.Println(colors) // map[Blue:#008000 Green:#0000FF Red:#FF0000 White:#FFFFFF]
}
```
