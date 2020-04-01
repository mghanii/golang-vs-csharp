package main

import "fmt"

func main() {
	a := 3
	b := 5

	b, a = a, b

	fmt.Println(a, b) // 5 3
}
