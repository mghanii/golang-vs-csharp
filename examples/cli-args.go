package main

import (
	"fmt"
	"os"
)

func main() {

	args := os.Args[1:] // first value is program path
	fmt.Println(args)
}
