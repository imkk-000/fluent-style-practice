package main

import "fmt"

func main() {
	var sum int
	var typeOfSum string
	numbers := []int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
	for _, number := range numbers {
		sum += number
	}
	if sum%2 == 1 {
		typeOfSum = "Odd"
	} else {
		typeOfSum = "Even"
	}
	fmt.Printf("sum of numbers is %d, and type of sum is %s.\n", sum, typeOfSum)
}
