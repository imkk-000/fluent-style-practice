package main

import "practice/myfluent"

func main() {
	TestExampleWith([]int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})
	TestExampleWith([]int{1})
	TestExampleWith([]int{2})
}

func TestExampleWith(testData []int) {
	m := &myfluent.MyFluentStruct{}
	m.SetArray(testData)
	m.CalculateSum()
	m.GetTypeOfSum()
	m.PrintResult()
}
