package br.com.rodrigo.apolo.factorymethods.problema;

import br.com.rodrigo.apolo.factorymethods.ProdutoDigital;
import br.com.rodrigo.apolo.factorymethods.ProdutoFisico;

public class TesteProduto {
    public static void main(String[] args) {
        ProdutoFisico produtoFisico = new ProdutoFisico();
        produtoFisico.setPossuiDimensoesFisicas(true);

        ProdutoDigital produtoDigital = new ProdutoDigital();
        produtoDigital.setPossuiDimensoesFisicas(false);
    }
}
