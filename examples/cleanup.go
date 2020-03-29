package main

import (
	"fmt"
	"os"
)

func main() {

	file, err := os.Create("/path/to/file")

	if err != nil {
		fmt.Println(err)
	}

	// Defere is used for clean-up activities
	// Deferred function calls are executed in
	// Last In First Out order after the surrounding function returns

	defer file.Close()

	// write to  file
	fmt.Fprintln(file, "test test...")

}
