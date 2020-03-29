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
