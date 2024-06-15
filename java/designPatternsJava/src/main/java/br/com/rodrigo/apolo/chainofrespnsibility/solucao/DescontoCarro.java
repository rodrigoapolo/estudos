package br.com.rodrigo.apolo.chainofrespnsibility.solucao;

import br.com.rodrigo.apolo.chainofrespnsibility.Carro;

import java.math.BigDecimal;

public abstract class DescontoCarro {
    protected DescontoCarro proximoDesconto;

    public DescontoCarro(DescontoCarro proximoDesconto) {
        this.proximoDesconto = proximoDesconto;
    }

    public abstract BigDecimal aplicaDesconto(Carro carro);
}
