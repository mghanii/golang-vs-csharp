package main

import "fmt"

func main() {

	// Initializes an empty map
	m := map[string]int{}

	m["key1"] = 10
	m["key2"] = 20
	m["key3"] = 30

	fmt.Println(m) // map[key1:10 key2:20 key3:30]

	// Deletes key from map
	delete(m, "key2")
	fmt.Println(m) // map[key1:10 key3:30]

	// Update value of existing key
	m["key1"] = 50
	fmt.Println(m) // map[key1:50 key3:30]

	// Iterate over a map
	for key, value := range m {
		fmt.Println(key, value)
	}

	// Checks if key exists
	if value, ok := m["key1"]; ok {
		fmt.Println(value) // 50
	}

	// Initializes a map with initial allocation
	m2 := make(map[string]int, 10)
	_ = m2

	// Initializes a map using map literals
	colors := map[string]string{
		"White": "#FFFFFF",
		"Red":   "#FF0000",
		"Green": "#0000FF",
		"Blue":  "#008000",
	}

	fmt.Println(colors) // map[Blue:#008000 Green:#0000FF Red:#FF0000 White:#FFFFFF]
}
