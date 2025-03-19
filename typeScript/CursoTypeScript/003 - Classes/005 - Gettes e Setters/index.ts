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

class Dener extends Pessoa{
    private _profisssao: string = "Programador";
    constructor(nome: string, idade: number){
        super(nome, idade);
    }

    get profissao(){
        if(this._profisssao === "Piloto de Drone"){
            return `Ele não é mais um programador mudou para ${this._profisssao}`;	
        }
        return this._profisssao;
    }

    set profissao(profissao: string){
        this._profisssao = profissao;
    }
}

const dener = new Dener("Daner", 27);
console.log(dener.profissao);
dener.profissao = "Piloto de Drone";
console.log(dener.profissao);