package main

import (
	"fmt"
	"runtime"
	"sync"
	"time"
)

func worker(id int, taskQueue <-chan func(w int)) {
	for fun := range taskQueue {
		fun(id)
	}
}

func main() {

	maxWorkers := runtime.GOMAXPROCS(0)
	taskQueue := make(chan func(w int), 1)
	wg := sync.WaitGroup{}

	wg.Add(maxWorkers)
	for w := 1; w <= maxWorkers; w++ {
		go func(id int) {
			worker(id, taskQueue)
			wg.Done()
		}(w)
	}

	for i := 1; i <= 7; i++ {
		t := i
		taskQueue <- func(w int) {
			fmt.Printf("Worker # %v is executing task # %v\n", w, t)
			time.Sleep(time.Second * 2)
		}
	}

	close(taskQueue)
	wg.Wait()
}
