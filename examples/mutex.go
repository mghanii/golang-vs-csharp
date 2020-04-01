package main

import (
	"fmt"
	"sync"
)

type SafeCounter struct {
	mutex   sync.Mutex
	Counter int
}

func (c *SafeCounter) Increment() {
	c.mutex.Lock()
	c.Counter++
	c.mutex.Unlock()
}

func (c *SafeCounter) Reset() {
	// we don't need the lock since assignment is atomic.
	c.Counter = 0
}

func main() {
	wg := sync.WaitGroup{}
	wg.Add(50)

	sc := SafeCounter{}
	for i := 0; i < 50; i++ {
		go func() {
			for c := 0; c < 1000; c++ {
				sc.Increment()
			}
			wg.Done()
		}()
	}

	wg.Wait()
	fmt.Println(sc.Counter)

	// RWMutex: a reader/writer mutual exclusion lock.
	// The lock can be held by an arbitrary number of readers or a single writer.
	_ := sync.RWMutex{}

}
