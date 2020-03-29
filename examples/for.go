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
