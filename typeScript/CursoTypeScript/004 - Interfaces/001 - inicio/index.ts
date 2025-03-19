interface IPessoa{
    nome: string,
    idade: number;
    readonly cpf: number;
    enabled(): boolean;
}

let pessoa : IPessoa = {
    nome: 'Maria',
    idade: 21,
    cpf: 12345678900,
    enabled: () => {
        return true;
    }
}


class Joao implements IPessoa{
    nome: string;
    idade: number;
    cpf: number;
    enabled: () => boolean;
    constructor(nome: string, idade: number, cpf: number, enabled: () => boolean){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
        this.enabled = enabled;
    }
}