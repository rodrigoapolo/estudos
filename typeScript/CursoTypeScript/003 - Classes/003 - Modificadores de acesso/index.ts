class Pessoa{
    private nome: string = "";
    private idade: number = 0;

    constructor(nome: string, idade: number){
        this.nome = nome;
        this.idade = idade;
    }

    public comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`;
    }

    protected fezAniversario(){
        return `O ${this.nome} faz tantos anos ${++this.idade}`;
    }
}

const pessoa = new Pessoa('João', 20);
const pessoa2 = new Pessoa('Maria', 25);


