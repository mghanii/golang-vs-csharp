package main

import (
	"fmt"
	"sync"
	"sync/atomic"
)

type SafeCounter struct {
	Counter int64
}

func (c *SafeCounter) Increment() {
	atomic.AddInt64(&c.Counter, 1)
}

func (c *SafeCounter) Reset() {
	// we don't need the lock since assignment is atomic.
	c.Counter = 0
}

func main() {

	sc := SafeCounter{}
	wg := sync.WaitGroup{}

	wg.Add(50)
	for i := 0; i < 50; i++ {
		go func() {
			for c := 0; c < 1000; c++ {

				sc.Increment()
			}
			wg.Done()
		}()
	}

	wg.Wait()

	fmt.Println(sc.Counter == 50*1000) // true
}
