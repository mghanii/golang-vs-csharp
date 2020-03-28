package main

import (
	"fmt"
	"math"
)

type Drawable interface {
	draw()
}

type Shape interface {
	getArea() float64
}

type Point struct {
	X, Y int
}

type Square struct {
	side float64
}

type Circle struct {
	center Point
	radius float64
}

// This method means type Circle implements the interface Shape
func (c Circle) getArea() float64 {
	return math.Pi * c.radius * c.radius
}

func (c Circle) draw() {
	fmt.Println("Drawing circle")
}

func (s Square) getArea() float64 {
	return s.side * s.side
}

func printArea(s Shape) {
	fmt.Println(s.getArea())
}

func main() {
	s := Square{side: 4}
	c := Circle{Point{3, 6}, 7}

	// Since both Square & Circle implement Shape interface, we can do the following:
	printArea(s) // 16
	printArea(c) // 153.93804002589985

	var d Drawable = c
	d.draw() // Drawing circle
}
