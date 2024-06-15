package br.com.rodrigo.apolo.chainofrespnsibility.solucao;

import br.com.rodrigo.apolo.chainofrespnsibility.Carro;
import br.com.rodrigo.apolo.chainofrespnsibility.Marca;

import java.math.BigDecimal;

public class VendaCarroSeviceComChainOfResponsibility {
    public BigDecimal calculaValorVenda(Carro carro){
        DescontoCarro desconto = new DescontoCarroFIAT(
                new DescontoCarroFORD(
                        new DescontoCarroValorMaiorQueCemMil(
                                new SemDireitoADesconto(null))));
        return desconto.aplicaDesconto(carro);
    }
}
