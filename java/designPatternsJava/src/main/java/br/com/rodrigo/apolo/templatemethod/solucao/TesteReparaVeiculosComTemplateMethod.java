package br.com.rodrigo.apolo.templatemethod.solucao;

import br.com.rodrigo.apolo.templatemethod.VeiculoParaReparo;
import br.com.rodrigo.apolo.templatemethod.problema.ReparaVeiculoComumService;
import br.com.rodrigo.apolo.templatemethod.problema.ReparaVeiculoDeLuxoService;

public class TesteReparaVeiculosComTemplateMethod {
    public static void main(String[] args) {
        System.out.println("-----------------------LUXO------------------------");

        VeiculoParaReparo veiculoDeLuxo = new VeiculoParaReparo();
        veiculoDeLuxo.setPorcentagemDano(49);

        ReparoVeiculoService rpl = new ReparaVeiculoLuxoServiceComTamplateMethod(veiculoDeLuxo);

        rpl.reaparaVeiculo();

        System.out.println("----------------------COMUM-------------------------");

        VeiculoParaReparo veiculoComum = new VeiculoParaReparo();
        veiculoComum.setPorcentagemDano(71);

        ReparoVeiculoService rpc = new ReparaVeiculoComumServiceComTamplateMethod(veiculoComum);

        rpc.reaparaVeiculo();
    }
}
