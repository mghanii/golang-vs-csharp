package main

import "fmt"

type Person struct {
	name string
	age  int
}

func (p *Person) printAge() {
	fmt.Printf("%v is %v years old\n", p.name, p.age)
}

func main() {

	// Creating a new struct
	p := Person{
		name: "Adam",
		age:  20,
	}

	fmt.Println(p)      // {Adam 20}
	fmt.Println(p.name) // Adam

	p2 := p // p2 is copy of p
	p2.name = "Isaac"
	fmt.Println(p)  // {Adam 20}
	fmt.Println(p2) //{Isaac 20}

	// & prefix yields a pointer to the struct
	p3 := &p // p3 & p poins to the same object
	p3.name = "Mohamed"
	fmt.Println(p)   // {Mohamed 20}
	fmt.Println(*p3) // {Mohamed 20}

	p.printAge() // Mohamed is 20 years old

	// Anonymous struct
	p4 := struct {
		name string
		age  int
	}{
		name: "Nora",
		age:  30,
	}

	fmt.Println(p4) // {Nora 30}

	// Structs are mutable
	p4.age = 50
	fmt.Println(p4) // {Nora 50}
}
