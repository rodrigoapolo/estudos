class Pessoa{
    protected nome: string = "";
    protected idade: number = 0;
   

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

class Daner extends Pessoa{
    private _profisssao: string = "Programador";
    constructor(nome: string, idade: number){
        super(nome, idade);
    }

    public profissao(){
        return `O ${this.nome} é ${this.profissao}`;
    }
}

class Maria extends Pessoa{

}

const maria = new Maria("Maria", 20);
const daner = new Daner("Daner", 20);

console.log(maria);
console.log(daner);
console.log(daner.profissao());
