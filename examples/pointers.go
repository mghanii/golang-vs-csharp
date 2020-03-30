package main

import "fmt"

func valTest(v int) {
	v = 5
}

func pointerTest(v *int) {
	// pointer dereferencing
	*v = 5
}

type Cat struct{ name string }

// value receiver doesn't mutate state
func (c Cat) valReceiverTest() {
	c.name = "Max"
}

// pointer receiver mutates state
func (c *Cat) pointerReceiverTest() {
	c.name = "Max"
}

func main() {

	a := 2

	// passing variables by value copies the value.
	valTest(a)
	fmt.Println(a)

	// &a: address operator, generates a pointer to a
	pointerTest(&a)

	fmt.Println(a)

	c := Cat{name: "Kitty"}
	// passes copy of c to valReceiverTest method
	c.valReceiverTest()
	fmt.Println(c.name)

	// passes address of c to pointerReceiverTest method
	c.pointerReceiverTest()
	fmt.Println(c.name)
}
