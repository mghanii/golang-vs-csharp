package main

import (
	"fmt"
	"sort"
)

type Cat struct {
	Name string
	Age  int
}

// implements sort.Interface.
type ByAgeThenName []Cat

func (c ByAgeThenName) Len() int { return len(c) }
func (c ByAgeThenName) Less(i, j int) bool {
	if c[i].Age < c[j].Age {
		return true
	}
	if c[i].Age > c[j].Age {
		return false
	}
	return c[i].Name < c[j].Name

}
func (c ByAgeThenName) Swap(i, j int) { c[i], c[j] = c[j], c[i] }

func main() {
	// Sort in ascending order
	arr1 := []int{5, 2, 9, -2, 0, 4}
	sort.Ints(arr1)
	fmt.Println(arr1)

	// Sort slice in descending order
	arr2 := []int{5, 2, 9, -2, 0, 4}
	sort.Sort(sort.Reverse(sort.IntSlice(arr2)))
	fmt.Println(arr2)

	// Sort strings
	arr3 := []string{"D", "A", "E", "B", "C"}
	sort.Strings(arr3)
	fmt.Println(arr3)

	// Sort custom objects
	arr4 := []Cat{
		Cat{"Max", 4},
		Cat{"Max", 3},
		Cat{"Angel", 1},
		Cat{"Kitty", 3},
	}
	sort.Sort(ByAgeThenName(arr4)) // sort by Age then Name
	fmt.Println(arr4)

}
