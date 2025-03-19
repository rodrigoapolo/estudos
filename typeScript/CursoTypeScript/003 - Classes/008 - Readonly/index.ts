class Pessoa {
    public readonly nome: string =  'João';
}

let pessoa = new Pessoa();

console.log(pessoa.nome);
pessoa.nome = "Maria";	
console.log(pessoa.nome);
