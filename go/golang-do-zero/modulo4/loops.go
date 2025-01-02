package main

import (
	"fmt"
	// "time"
)

func main(){
	// sum := 0

	// for i := 0; i < 10; i++ {
	// 	sum += 1
	// }

	// fmt.Println(sum)


	// for{
	// 	fmt.Println("Golang do zero!!")
	// 	time.Sleep(2 * time.Second)
	// }

	frutas := []string{"laranja", "maça", "banana", "uva", "kiwi"}
	for _, fruta := range frutas{
		fmt.Println(fruta)
	}
}

