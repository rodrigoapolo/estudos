package main

import "fmt"


type Cachorro struct {
	Raca string
	Cor string
	Patas int
}

type Gato struct {
	Cor string
	Patas int
}

func (c Cachorro) Barulho() string {
	return "au au"
}

func (c Cachorro) NumeroDepatas() int {
	return c.Patas
}


func (g Gato) Barulho() string {
	return "miau"
}

func (g Gato) NumeroDepatas() int {
	return g.Patas
}

type Animal interface{
	Barulho() string
	NumeroDepatas() int
}

func fazBarulho(animal Animal){
	fmt.Println(animal.Barulho())
}

type Pessoa struct{
	Nome string
	Idade int
	Prof string
	TempoDeProfissao int
}

type Crianca struct{
	Nome string
	Idade int
}

func (c Crianca) FalaBomDia() string{
	return fmt.Sprintf("%s deseja bom dia pra voce!", c.Nome)
}

func (p Pessoa) FalaBomDia() string{
	return fmt.Sprintf("%s deseja bom dia pra voce!", p.Nome)
}

func (p Pessoa) Profissao() string{
	return fmt.Sprintf("%s tem %d anos como %s", p.Nome, p.TempoDeProfissao, p.Profissao)
}

type Adulto interface{
	FalaBomDia() string
	Profissao() string
}

func FalaBomDia(adulto Adulto) string{
	return adulto.FalaBomDia()
}

func main(){
	// cachorro := Cachorro{
	// 	Raca: "spitz alemao",
	// 	Cor: "preto",
	// 	Patas: 4,
	// }

	// gato := Gato{
	// 	Cor: "branco",
	// 	Patas: 4,
	// }
	
	// fmt.Println(cachorro.Barulho())
	// fmt.Println(cachorro.NumeroDepatas())
	// fmt.Println(gato.Barulho())
	// fmt.Println(gato.NumeroDepatas())

	// fazBarulho(gato)
	// fazBarulho(cachorro)

	adulto := Pessoa{
		Nome: "steph",
		Idade: 28,
		Prof: "dev",
		TempoDeProfissao: 6,
	}


	crianca := Crianca{
		Nome: "bento",
		Idade: 4,
	}

	FalaBomDia(adulto)
}