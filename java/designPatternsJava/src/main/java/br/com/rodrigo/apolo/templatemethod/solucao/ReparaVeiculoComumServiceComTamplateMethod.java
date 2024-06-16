package br.com.rodrigo.apolo.templatemethod.solucao;

import br.com.rodrigo.apolo.templatemethod.VeiculoParaReparo;

public class ReparaVeiculoComumServiceComTamplateMethod extends ReparoVeiculoService {
    private VeiculoParaReparo veiculoParaReparo;

    public ReparaVeiculoComumServiceComTamplateMethod(VeiculoParaReparo veiculoParaReparo) {
        this.veiculoParaReparo = veiculoParaReparo;
    }

    @Override
    protected boolean veiculoParaReparo() {
        return veiculoParaReparo.getPorcentagemDano() <= 70;
    }
}
