package main

import "fmt"

// this method can be called with variable number of arguments
func sum(values ...int) (result int) {

	for _, v := range values {
		result += v
	}

	return
}

func transform(transformer func(v int) int, value int) int {
	return transformer(value)
}

// multiple return values
func divide(a float32, b float32) (float32, error) {
	if b == 0.0 {
		return 0, fmt.Errorf("Attempted to divide by zero")
	}
	return a / b, nil
}

// Go supports methods defined on struct types.
type user struct {
	name string
}

// value receiver (receives a copy of user instance when called)
func (u user) printName() {
	fmt.Println(u.name)
}

//  pointer receiver (receives a pointer to user instance when called)
func (u *user) printName2() {
	fmt.Println(u.name)
}

func main() {
	fmt.Println(sum(1, 2))    // 3
	fmt.Println(sum(1, 2, 3)) //6

	// Anonymous function
	func(v int) {
		fmt.Println(v) // 4
	}(4)

	// passing func around as variable or parameter
	var square = transform(func(v int) int {
		return v * v
	}, 4)

	fmt.Println(square) // 16

	v, _ := divide(4, 2)
	fmt.Println(v) // 2

	var usr = user{name: "Adam"}

	usr.printName()     // Adam
	(&usr).printName2() // Adam

}
