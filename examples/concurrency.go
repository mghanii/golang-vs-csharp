package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"log"
	"net/http"
	"sync"
)

type Quote struct {
	Quote  string `json:"quote"`
	Author string `json:"author"`
}

func parseBody(r *http.Response, x interface{}) {
	defer r.Body.Close()
	if body, err := ioutil.ReadAll(r.Body); err == nil {
		if err := json.Unmarshal(body, x); err != nil {
			log.Fatal(err)
			return
		}
	} else {
		log.Fatal(err)
	}
}

func getRandomQuote() Quote {
	res, err := http.Get("http://quotes.stormconsultancy.co.uk/random.json")
	if err != nil {
		log.Fatal(err)
	}
	q := Quote{}
	parseBody(res, &q)

	return q
}

func displayQuotes(ch <-chan Quote) {
	for {
		select {
		case quote := <-ch:
			fmt.Printf("%+v\n", quote)
		case <-doneCh:
			break
		}
	}
}

var doneCh = make(chan struct{})

func main() {
	quotesCount := 5
	quotesCh := make(chan Quote, quotesCount)
	wg := sync.WaitGroup{}

	go displayQuotes(quotesCh)

	// get random quotes
	wg.Add(quotesCount)
	for i := 0; i < quotesCount; i++ {
		go func(ch chan<- Quote) {
			defer wg.Done()
			quote := getRandomQuote()
			ch <- quote
		}(quotesCh)
	}

	wg.Wait()
	doneCh <- struct{}{}
}
