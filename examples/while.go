package main

import "fmt"

func main() {

	// we can get same while behavior using for:
	var attempt = 1

	for attempt <= 3 {
		fmt.Printf("attempt # %v\n", attempt)
		// do other stuff
		attempt++
	}
}
