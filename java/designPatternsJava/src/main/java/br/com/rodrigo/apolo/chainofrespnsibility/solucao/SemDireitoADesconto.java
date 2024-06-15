package br.com.rodrigo.apolo.chainofrespnsibility.solucao;

import br.com.rodrigo.apolo.chainofrespnsibility.Carro;
import br.com.rodrigo.apolo.chainofrespnsibility.Marca;

import java.math.BigDecimal;

public class SemDireitoADesconto extends DescontoCarro{
    public SemDireitoADesconto(DescontoCarro proximoDesconto) {
        super(proximoDesconto);
    }

    @Override
    public BigDecimal aplicaDesconto(Carro carro) {
        return BigDecimal.ZERO;
    }
}
