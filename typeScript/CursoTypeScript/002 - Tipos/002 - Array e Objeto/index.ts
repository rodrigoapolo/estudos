let array1: [string, string, number, boolean] = ["Dener Troquatte", "Teste", 234, false];
let array2: Array<string | number | boolean> = [
    23423, "Dener Troquatte", false, "Teste", "Teste2"];

console.log(array1);
console.log(array2);

let obj1: {nome: string, sobrenome: string, idade: number, deuBom: boolean} = {
    nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true};

let obj2: Array<{nome: string, sobrenome: string, idade: number, deuBom: boolean}> = [
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
    {nome: "Dener", sobrenome: "Troquatte", idade: 123, deuBom: true},
];

console.log(obj1);
console.log(obj2);