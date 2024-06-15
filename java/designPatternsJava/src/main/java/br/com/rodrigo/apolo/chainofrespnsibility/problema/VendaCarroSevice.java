package br.com.rodrigo.apolo.chainofrespnsibility.problema;

import br.com.rodrigo.apolo.chainofrespnsibility.Carro;
import br.com.rodrigo.apolo.chainofrespnsibility.Marca;

import java.math.BigDecimal;

public class VendaCarroSevice {
    public BigDecimal calculaValorVenda(Carro carro){
        BigDecimal valorVenda = carro.getPreco();

        if(Marca.FIAT.equals(carro.getMarca())){
            return valorVenda.subtract(new BigDecimal(1000));
        }

        if(Marca.FORD.equals(carro.getMarca())){
            return valorVenda.subtract(new BigDecimal(2000));
        }

        if(carro.getPreco().compareTo(new BigDecimal(100000.00)) > 0){
            return valorVenda.subtract(new BigDecimal(10000));
        }
        return valorVenda;
    }
}
