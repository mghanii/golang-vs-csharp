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
	// 📝 A slice is a descriptor for a contiguous segment of an underlying array and provides access to a numbered sequence of elements from that array.

	var t []byte = []byte{1, 2, 3}

	// ♦♦ Struct types ♦♦
	// 📝 A struct is a sequence of named elements, called fields, each of which has a name and a type.

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
