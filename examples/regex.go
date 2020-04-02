package main

import (
	"fmt"
	"regexp"
)

func main() {
	match, _ := regexp.MatchString("^[a-z0-9_-]{3,16}$", "max")
	fmt.Println(match)

	regex, _ := regexp.Compile("p([a-z]+)ch")
	fmt.Println(regex.MatchString("peach"))
	fmt.Println(regex.FindString("peach punch"))

	regex, _ = regexp.Compile("[0-9]+")
	fmt.Println(regex.FindAllString("A1B2C3DE4F5", -1))

}
