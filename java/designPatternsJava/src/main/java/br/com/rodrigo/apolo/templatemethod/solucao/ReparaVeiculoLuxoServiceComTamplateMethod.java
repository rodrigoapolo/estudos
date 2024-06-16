package br.com.rodrigo.apolo.templatemethod.solucao;

import br.com.rodrigo.apolo.templatemethod.VeiculoParaReparo;

public class ReparaVeiculoLuxoServiceComTamplateMethod extends ReparoVeiculoService {
    private VeiculoParaReparo veiculoParaReparo;

    public ReparaVeiculoLuxoServiceComTamplateMethod(VeiculoParaReparo veiculoParaReparo) {
        this.veiculoParaReparo = veiculoParaReparo;
    }

    @Override
    protected boolean veiculoParaReparo() {
        return veiculoParaReparo.getPorcentagemDano() <= 50;
    }
}
