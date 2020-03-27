package main

import "fmt"

func main() {

	// declare empty map
	m := map[string]int{} // or make(map[string]int)

	m["key1"] = 10
	m["key2"] = 20
	m["key3"] = 30

	fmt.Println(m) // map[key1:10 key2:20 key3:30]

	delete(m, "key2")
	fmt.Println(m) // map[key1:10 key3:30]

	// update value of existing key
	m["key1"] = 50
	fmt.Println(m) // map[key1:50 key3:30]

	// iterate over map
	for key, value := range m {
		fmt.Println(key, value)
	}

	// check if key exists

	if value, ok := m["key1"]; ok {
		fmt.Println(value) // 50
	}

	colors := map[string]string{
		"White": "#FFFFFF",
		"Red":   "#FF0000",
		"Green": "#0000FF",
		"Blue":  "#008000",
	}

	fmt.Println(colors) // map[Blue:#008000 Green:#0000FF Red:#FF0000 White:#FFFFFF]
}
