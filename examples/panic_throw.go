package main

import (
	"fmt"
)

func divide(a int, b int) int {
	if b == 0.0 {
		// panic is similar to C#'s exceptions, it's a run-time error.
		// panic() function terminates the flow of control and starts panicking.
		panic("Attempted to divide by zero")
	}
	return a / b
}

func main() {
	// recover(): regains control of a panicking goroutine.
	// defer function always run even if the program panics.
	defer func() {
		if x := recover(); x != nil {
			fmt.Println("run time panic: ", x)
		}
	}()

	fmt.Println("main start")
	_ = divide(4, 0)

}
