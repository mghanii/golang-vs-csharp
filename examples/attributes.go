package main

import(
"fmt" 
"reflect"
)

type  Person struct{
	Name string `json:"name"`
}

func main()  {
	
	t:= reflect.TypeOf(Person{})
	f, _ := t.FieldByName("Name") 
	fmt.Println(f.Tag) // json:"name"
}