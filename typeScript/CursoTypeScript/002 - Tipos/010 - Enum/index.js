var Mes;
(function (Mes) {
    Mes["JAN"] = "Janeiro";
    Mes["FEV"] = "Fevereiro";
    Mes["MAR"] = "Mar\u00E7o";
})(Mes || (Mes = {}));
console.log(Mes);
console.log(Mes.JAN);
var pessoa = {
    nome: "João",
    mesAniversario: Mes.MAR
};
if (pessoa.mesAniversario === Mes.MAR) {
    console.log(pessoa);
}
