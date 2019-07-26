package myfluent

import "fmt"

type MyFluentStruct struct {
	numbers   []int
	sum       int
	typeOfSum string
}

func (mfs *MyFluentStruct) SetArray(numbers []int) MyFluentStruct {
	mfs.numbers = numbers
	return *mfs
}

func (mfs *MyFluentStruct) CalculateSum() MyFluentStruct {
	for _, number := range mfs.numbers {
		mfs.sum += number
	}
	return *mfs
}

func (mfs *MyFluentStruct) GetTypeOfSum() MyFluentStruct {
	if mfs.sum%2 == 1 {
		mfs.typeOfSum = "Odd"
	} else {
		mfs.typeOfSum = "Even"
	}
	return *mfs
}

func (mfs MyFluentStruct) PrintResult() MyFluentStruct {
	fmt.Printf("sum of numbers is %d, and type of sum is %s.\n", mfs.sum, mfs.typeOfSum)
	return mfs
}
