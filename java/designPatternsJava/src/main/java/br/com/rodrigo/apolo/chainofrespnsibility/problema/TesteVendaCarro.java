package br.com.rodrigo.apolo.chainofrespnsibility.problema;

import br.com.rodrigo.apolo.chainofrespnsibility.Carro;
import br.com.rodrigo.apolo.chainofrespnsibility.Marca;

import java.math.BigDecimal;

public class TesteVendaCarro {
    public static void main(String[] args) {
        VendaCarroSevice vendaCarroSevice = new VendaCarroSevice();

        Carro carro1 = new Carro();
        carro1.setMarca(Marca.FORD);
        carro1.setModelo("Fusion");
        carro1.setPreco(new BigDecimal(90000.00));

        BigDecimal valorVenda1 =  vendaCarroSevice.calculaValorVenda(carro1);
        System.out.println("Valor de venda Fusion: "+ carro1.getPreco());
        System.out.println("Valor de venda Fusion com desconto: "+ valorVenda1);

        Carro carro2 = new Carro();
        carro2.setMarca(Marca.FIAT);
        carro2.setModelo("Uno");
        carro2.setPreco(new BigDecimal(40000.00));

        BigDecimal valorVenda2 =  vendaCarroSevice.calculaValorVenda(carro2);
        System.out.println("Valor de venda Uno: "+ carro2.getPreco());
        System.out.println("Valor de venda Uno com desconto: "+ valorVenda2);

        Carro carro3 = new Carro();
        carro3.setMarca(Marca.CHEVROLET);
        carro3.setModelo("Camaro");
        carro3.setPreco(new BigDecimal(2000000.00));

        BigDecimal valorVenda3 =  vendaCarroSevice.calculaValorVenda(carro3);
        System.out.println("Valor de venda Camaro: "+ carro3.getPreco());
        System.out.println("Valor de venda Camaro com desconto: "+ valorVenda3);
    }
}
