package main

import (
	"fmt"
	"reflect"
)

type Iterator func() (item interface{}, ok bool)

func Iterate(collection interface{}) Iterator {

	source := reflect.ValueOf(collection)
	len := source.Len()
	i := 0

	if source.Kind() != reflect.Slice && source.Kind() != reflect.Array {
		panic("can't iterate over non-slice or array types")
	}

	return func() (item interface{}, ok bool) {
		ok = i < len
		if ok {
			item = source.Index(i).Interface()
			i++
		}

		return
	}
}

func main() {
	a := []int{1, 2, 3, 4, 5}

	var next Iterator = Iterate(a)

	for item, ok := next(); ok; item, ok = next() {
		fmt.Print(item, ", ")
	}
}
