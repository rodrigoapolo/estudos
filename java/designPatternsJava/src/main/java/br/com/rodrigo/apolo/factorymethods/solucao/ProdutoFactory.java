package br.com.rodrigo.apolo.factorymethods.solucao;

import br.com.rodrigo.apolo.factorymethods.Produto;
import br.com.rodrigo.apolo.factorymethods.ProdutoDigital;
import br.com.rodrigo.apolo.factorymethods.ProdutoFisico;
import br.com.rodrigo.apolo.factorymethods.TipoProdutoEnum;

public class ProdutoFactory {
    public static Produto getInstance(TipoProdutoEnum tipoProdutoEnum){
        switch (tipoProdutoEnum){
            case FISICO:
                ProdutoFisico produtoFisico = new ProdutoFisico();
                produtoFisico.setPossuiDimensoesFisicas(true);
                return produtoFisico;
            case DIGITAL:
                ProdutoDigital produtoDigital = new ProdutoDigital();
                produtoDigital.setPossuiDimensoesFisicas(false);
                return produtoDigital;
            default:
                throw new IllegalArgumentException("Tipo de produto não disponivel");
        }
    }
}
