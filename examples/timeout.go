package main

import (
	"fmt"
	"time"
)

func main() {

	ch := make(chan string, 1)
	go func() {
		// Simulate some work.
		time.Sleep(2 * time.Second)
		ch <- "done"
	}()

	select {
	case res := <-ch:
		fmt.Println(res)
	case <-time.After(1 * time.Second):
		fmt.Println("timed out")
	}
}
