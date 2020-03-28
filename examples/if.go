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
