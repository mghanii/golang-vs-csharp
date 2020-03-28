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
		break // break out of loop
	}

}
