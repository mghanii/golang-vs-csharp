package main

import (
	"fmt"
)

func main() {

	var a [5]int
	fmt.Println(a) // [0 0 0 0 0]

	// checks array length
	fmt.Println(len(a)) // 5

	// update or get element by index
	a[0] = 4

	// initializer syntax
	a1 := [3]int{1, 2, 3} // this is equivalent to 	a1 := [...]int{1, 2, 3}

	a2 := a1 // a2 is assgined to a copy of a1 contents

	a2[1] = 5

	fmt.Println(a1) // [1 2 3]
	fmt.Println(a2) // [1 5 3]

	var a3 *[3]int = &a1 // a3 & a1  points to the same data
	a3[1] = 7

	fmt.Println(a1)  // [1 7 3]
	fmt.Println(*a3) // [1 7 3]

	// multidimensional arrays

	// two dimensional array of 4 rows and 3 columns.
	var array2D [4][3]int
	n := 1
	for i := 0; i < 4; i++ {
		for j := 0; j < 3; j++ {
			array2D[i][j] = n
			n++
		}
	}

	fmt.Println(array2D) // [[1 2 3] [4 5 6] [7 8 9] [10 11 12]]
}
