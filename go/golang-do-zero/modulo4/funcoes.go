
package main

import "fmt"

func main(){
	fmt.Println(soma(42, 13))
	fmt.Println(subtracao(42, 13))

	// nome1, nome2 := printaNome("Rodrigo")
	nome1, _ := printaNome("Rodrigo", "Santos")
	fmt.Println(nome1)
	
}

func soma(x int, y int) int{
	return x + y
}

func subtracao(x int, y int) int{
	return x - y
}
// funcao com letra minúcula
// funcao é privada
// funco ela so pode ser utilizada no proprio pacote
func printaNome(nome, sobrenome string) (string, string){
	return nome, sobrenome
}