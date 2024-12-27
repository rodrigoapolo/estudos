package main

import "fmt"

func main(){
	// valor := 1
	// if valor == 1{
	// 	fmt.Println("Valor é igual a 1")
	// } else{
	// 	fmt.Println("Valor não é igual a 1")
	// }

	numero := 2
	if numero == 1{
		fmt.Println("Valor é igual a 1")
	} else if numero == 2{
		fmt.Println("Valor é igual a 2")
	} else{
		fmt.Println("Valor é diferente de 1 e 2")
	}

	fmt.Println(1+1)
	fmt.Println(2-1)
	fmt.Println(2*2)
	fmt.Println(10/2)
	fmt.Println(10%2)
	
	if 7%2 == 0{
		fmt.Println("7 é par")
	} else{
		fmt.Println("7 é impar")
	}
}