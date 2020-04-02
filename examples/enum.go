package main

import "fmt"

type LogLevel uint8
type Border uint8

const (
	Trace LogLevel = iota + 1
	Debug
	Information
	Error
	Warning
)
const (
	Top    Border = 1 // 1 << iota
	Right         = 2
	Bottom        = 4
	Left          = 8
)

func main() {
	level := Information
	fmt.Println(level)            // 3
	fmt.Println(Information == 3) // true

	border := Bottom | Left

	// Checks if left border has set
	fmt.Println(border&Left == Left) // true

	// Removes left border
	border = border &^ Left
	fmt.Println(border == Bottom) // true

}
