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
