class Pessoa{
    nome: string = "";
    idade: number = 0;

    constructor(nome: string, idade: number){
        this.nome = nome;
        this.idade = idade;
    }

    comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`;
    }

    fezAniversario(){
        return `O ${this.nome} faz tantos anos ${++this.idade}`;
    }
}


const pessoa1 = new Pessoa("Maria", 25);
console.log(pessoa1.comer("Feijoada"));
console.log(pessoa1.fezAniversario());
