package main

import (
	"fmt"
	"strconv"
)

func main() {

	var a int = 20
	b := float32(a)
	fmt.Printf("%v, %T\n", b, b) // 20, float32

	d := strconv.Itoa(a)
	fmt.Printf("%v, %T\n", d, d) // 20, string

	e, err := strconv.Atoi("123")
	if err == nil {
		fmt.Printf("%v, %T\n", e, e)
	}

	g, err := strconv.ParseInt("235", 10, 64)
	if err == nil {
		fmt.Printf("%v, %T\n", g, g)
	}
}
