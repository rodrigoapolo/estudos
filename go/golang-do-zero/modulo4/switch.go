package main

import "fmt"

func main(){
	posicao := 10

	switch posicao {
	case 1:
		fmt.Println("Primeiro lugar")
	case 2:
		fmt.Println("Segundo lugar")
	case 3:
		fmt.Println("Terceiro lugar")
	default:
		fmt.Println("Uw")
	}

	nome := "bob"
	switch nome {
	case "steph":
		fmt.Println("É um pessoa")
	case "bento":
		fmt.Println("É um cachorro")
	case "bob":
		fmt.Println("É um personagem")
	}
}