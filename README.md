# Golang for C# developers

## Contents

- [Comments](#Comments)
- [Variables](#Variables)
- [Types](#Types)

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
	// 📝 Strings are immutable: once created, it is impossible to change its contents.

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
