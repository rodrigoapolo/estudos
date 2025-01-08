package main

import "fmt"

func zeroValue(i int){
	i = 0 
}

func zeroPointer(i *int){
	*i = 0
}


func main(){
	i := 1
	fmt.Println("Valor inicial:", i)
	fmt.Println("Valor end de memoria:", &i)

	zeroValue(i)
	fmt.Println("zeroval:", i)

	zeroPointer(&i)
	fmt.Println("zeroptr:", i)

	fmt.Println("pointer:", &i)

	// a := &i
	// fmt.Println("variavel a:", a)
	// fmt.Println("variavel *a:", *a)
	// fmt.Println("variavel &a:", &a)
}