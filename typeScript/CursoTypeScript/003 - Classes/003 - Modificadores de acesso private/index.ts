class Pessoa{
    private nome: string = "";
    private idade: number = 0;
    private _profisssao: string = "Programador";

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