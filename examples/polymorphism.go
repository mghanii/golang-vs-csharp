package main

import (
	"fmt"
	"math"
	"reflect"
)

type Shape interface {
	Area() float64
}

type Square struct {
	side float64
}

type Circle struct {
	radius float64
}

func (c Circle) Area() float64 {
	return math.Pi * c.radius * c.radius
}

func (s Square) Area() float64 {
	return s.side * s.side
}

func displayArea(shape Shape) {
	fmt.Printf("area of %v is %v\n", reflect.TypeOf(shape).Name(), shape.Area())
}

func main() {

	shapes := []Shape{Square{3}, Circle{3}}
	for _, v := range shapes {
		displayArea(v)
	}
}
