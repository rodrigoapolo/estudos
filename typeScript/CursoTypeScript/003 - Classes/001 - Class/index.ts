class Pessoa{
    nome: string = "Rodrigo";
    idade: number = 25;

    constructor(nome: string, idade: number){
        this.nome = nome;
        this.idade = idade;
    }
}


const pessoa1 = new Pessoa("Maria", 25);


console.log(pessoa1);
console.log(pessoa1.nome);