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
