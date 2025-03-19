export namespace Pessoa{
     export namespace Pessoa1{
        export let nome = "João";
        const data = 1 + 1;
        export const calc = () => {
            return data;
        }
    }

    export namespace Maria{
        export let nome = "João";
        const data = 1 + 1;
        export const calc = () => {
            return data;
        }
    }
}

console.log(Pessoa.Pessoa1.nome);
console.log(Pessoa.Maria.nome);