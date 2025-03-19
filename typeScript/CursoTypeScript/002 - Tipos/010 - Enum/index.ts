enum Mes{
    JAN = "Janeiro",
    FEV = "Fevereiro",
    MAR = "Março",
}

console.log(Mes);
console.log(Mes.JAN);


const pessoa: {nome: string, mesAniversario: string } = {
    nome: "João",
    mesAniversario: Mes.MAR
}

if(pessoa.mesAniversario === Mes.MAR){
    console.log(pessoa);
}