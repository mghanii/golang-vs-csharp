package main

import "fmt"

type Animal struct {
	name string
	age  int
}

// struct embed­ding
type Dog struct {
	Animal
	breed string
}

// struct composition
type Cat struct {
	pet Animal
}

func (a *Animal) Description() string {
	return fmt.Sprintf("name: %v, age: %v", a.name, a.age)
}

func (a *Animal) Sleep() {
	fmt.Printf("%v is sleeping\n", a.name)
}

func (c *Cat) Sleep() {
	c.pet.Sleep()
}

func main() {
	dog := Dog{Animal: Animal{name: "Max", age: 3}, breed: "Basenji"}
	fmt.Println(dog.Description())
	dog.Sleep()

	cat := Cat{pet: Animal{name: "Kitty", age: 2}}

	fmt.Println(cat.pet.Description())
	cat.Sleep()

}
