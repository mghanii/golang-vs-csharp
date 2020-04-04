package main

import "fmt"

// unexported method, accessible only within 'main' package
func saySomething() {
	fmt.Println("Hi......")
}

// exported type, visible to other packages
type ExportedStruct struct {
	field1 string // unexported field
	Field2 string // exported field
}

func main() {
	saySomething()
}
