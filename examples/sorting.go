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
type ByAge []Cat

func (c ByAge) Len() int           { return len(c) }
func (c ByAge) Less(i, j int) bool { return c[i].Age < c[j].Age }
func (c ByAge) Swap(i, j int)      { c[i], c[j] = c[j], c[i] }

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
		Cat{"Kitty", 2},
		Cat{"Max", 1},
	}
	sort.Sort(ByAge(arr4))
	fmt.Println(arr4)

}
