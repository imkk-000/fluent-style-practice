package main

import "practice/myfluent"

func main() {
	m := &myfluent.MyFluentStruct{}
	m.SetArray([]int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})
	m.CalculateSum()
	m.GetTypeOfSum()
	m.PrintResult()
}
