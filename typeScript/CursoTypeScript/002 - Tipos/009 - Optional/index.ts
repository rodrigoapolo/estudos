const fn = (nome: string, idade?: number) => {
    if(!idade){
        return `Olá, ${nome}! idade: sem valor definido`;
    }
  return `Olá, ${nome}! Você tem ${idade} anos.`;
};

console.log(fn("João", 31));
console.log(fn("João"));

const pessoa: { nome: string; idade?: number } = {
  nome: "João",
  
};