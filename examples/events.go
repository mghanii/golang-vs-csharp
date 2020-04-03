package main

import (
	"fmt"
)

type EventEmitter map[string][]chan string

type Person struct {
	username string
	email    string
	emitter  EventEmitter
}

func (p *Person) UpdateEmail(email string) bool {
	if p.email != email {
		msg := fmt.Sprintf("%v updated his email from '%v' to '%v'", p.username, p.email, email)
		p.email = email
		p.emitter.Emit("email-updated", msg)
		return true
	}
	return false
}

func (p *Person) addEmailUpdateListener(ch chan string) {
	p.emitter.addEventListener("email-updated", ch)
}

func (p *Person) removeEmailUpdateListener(ch chan string) {
	p.emitter.removeEventListener("email-updated", ch)
}

func (emitter EventEmitter) addEventListener(event string, ch chan string) {
	if _, ok := emitter[event]; ok {
		emitter[event] = append(emitter[event], ch)
	} else {
		emitter[event] = []chan string{ch}
	}
}
func (emitter EventEmitter) removeEventListener(event string, ch chan string) {

	if _, ok := emitter[event]; ok {
		listeners := emitter[event]
		for i := range listeners {
			if listeners[i] == ch {
				emitter[event] = append(listeners[:i], listeners[i+1:]...)
				break
			}
		}
	}
}

func (emitter EventEmitter) Emit(event string, msg string) {
	if _, ok := emitter[event]; ok {
		for _, handler := range emitter[event] {
			go func(handler chan string) {
				handler <- msg
			}(handler)
		}
	}
}

func main() {

	p := Person{
		username: "Adam",
		email:    "first@first.com",
		emitter:  EventEmitter{},
	}

	listeners := []chan string{
		make(chan string),
		make(chan string),
	}
	for i, ch := range listeners {
		p.addEmailUpdateListener(ch)
		go func(c chan string, j int) {
			for {
				msg := <-c
				fmt.Printf("listener#%v: %v\n", j, msg)
			}
		}(ch, i)
	}

	p.UpdateEmail("second@second.com")
	// Removes listener#0
	p.removeEmailUpdateListener(listeners[0])
	p.UpdateEmail("third@third.com")

	fmt.Scanln()
}
