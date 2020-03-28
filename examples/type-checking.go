package main

import (
	"fmt"
	"reflect"
)

func main() {

	var a int64 = 4

	fmt.Println(reflect.TypeOf(a).Kind() == reflect.Int64)

	var b interface{} = 4

	if _, isInt := b.(int); isInt {
		fmt.Println("i is int")
	}

}
