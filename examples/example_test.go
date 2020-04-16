package example

import (
	"fmt"
	"testing"
)

func sum(a, b int) int {
	return a + b
}

func TestSum(t *testing.T) {
	data := []struct {
		a, b, sum int
	}{
		{2, 4, 6},
		{-1, 1, 0},
		{-5, 3, -2},
	}

	for _, tt := range data {
		name := fmt.Sprintf("%d+%d", tt.a, tt.b)
		t.Run(name, func(t *testing.T) {
			got := sum(tt.a, tt.b)
			if got != tt.sum {
				t.Errorf("expected %d, got %d", tt.sum, got)
			}
		})
	}
}
