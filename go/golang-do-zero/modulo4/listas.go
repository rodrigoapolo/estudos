package main

import "fmt"

func main(){
	// var array [2] string
	// array[0] = "Hello"
	// array[1] = "World"
	// fmt.Println(array[0], array[1])
	// fmt.Println(array)

	// numPrimo := [6]int{2,3,5,7,11,13}
	// fmt.Println(numPrimo)
	// fmt.Println(numPrimo[0:3])
	// fmt.Println(numPrimo[:1])
	// fmt.Println(numPrimo[1:])


	//var slice []string
	slice := make([]string, 5)
	slice[0] = "Hello"
	slice[1] = "World"
	fmt.Println(slice[0], slice[1])
	fmt.Println(slice)
	fmt.Println(len(slice))

	numPares := []int{2,4,6,8,10,12}
	fmt.Println(numPares)

	numPares = append(numPares, 14)
	fmt.Println(numPares)
}