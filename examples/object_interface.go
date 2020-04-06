package main

import (
	"fmt"
	"reflect"
	"time"
)

func main() {

	arr := []interface{}{
		44,
		4.5,
		"string",
		time.Now(),
		true,
		'a',
		[]int{1, 2, 3},
	}
	for _, v := range arr {
		fmt.Println(reflect.TypeOf(v))
	}

}
