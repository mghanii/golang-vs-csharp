package main

import (
	"fmt"
	"time"
)

func main() {
	w := fmt.Println

	w(time.Now()) // 2020-04-02 20:09:15.0305182 +0200 EET m=+0.002996501

	dt := time.Date(2020, 04, 02, 19, 15, 40, 1245678, time.UTC)

	w(dt.Year())       // 2020
	w(dt.Month())      // April
	w(dt.Day())        // 2
	w(dt.Hour())       // 19
	w(dt.Minute())     // 15
	w(dt.Second())     // 40
	w(dt.Nanosecond()) // 1245678
	w(dt.Location())   // UTC
	w(dt.Weekday())    // Thursday

	dt2 := dt.AddDate(0, 0, 2)
	diff := dt2.Sub(dt)
	w(diff) // 48h0m0s

	w(dt2.Before(dt)) // false
	w(dt2.After(dt))  // true
	w(dt2.Equal(dt))  // false

	w(dt.Unix()) // 1585854940

	zone, offset := dt.Zone() // UTC
	w(zone, offset)           // 0
}
