package main

import "fmt"

func f1() {
	fmt.Println("Executing f1...")
}
func f2() {
	fmt.Println("Executing f2...")
}
func f3() {
	fmt.Println("Executing f3...")
}

func main() {

	a := 2

	switch {
	case a == 1:
		f1()
	case a == 2:
		f2()
	default:
		f3()
	}

	b := 10

	switch b {
	case 1, 10, 100:
		f1()
	case 2, 20:
		f2()
	default:
		f3()
	}

	switch c := a - 2; {
	case c < 0:
		fmt.Println("c is negative")
	case c > 0:
		fmt.Println("c is positive")
	default:
		fmt.Println("c is 0")
	}

	// Type switch: compares types rather than values.

	var d interface{} = 4

	switch d.(type) {
	case int:
		fmt.Println("d is int")
	case float32:
		fmt.Println("d is float32")
	default:
		fmt.Println("type is not known")
	}

	// above switch could be rewritten:

	if _, isInt := d.(int); isInt {
		fmt.Println("d is int")
	} else if _, isFloat32 := d.(float32); isFloat32 {
		fmt.Println("d is float32")
	} else {
		fmt.Println("type is not known")
	}
}
