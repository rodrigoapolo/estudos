package br.com.rodrigo.apolo.templatemethod.problema;

import br.com.rodrigo.apolo.templatemethod.VeiculoParaReparo;

public class ReparaVeiculoDeLuxoService {
    private VeiculoParaReparo veiculoParaReparo;

    public ReparaVeiculoDeLuxoService(VeiculoParaReparo veiculoParaReparo) {
        this.veiculoParaReparo = veiculoParaReparo;
    }

    public void reaparaVeiculo(){
        entradaOficina();
        analisarDanos();
        if(veiculoParaReparo()){
            reapararVeiculo();
            notificarReparoParaSeuradora();
        }else{
            notificarPerdaTotalParaSeguradora();
        }
    }

    private void reapararVeiculo() {
        System.out.println("Reparando veiculo...");
    }

    private void notificarPerdaTotalParaSeguradora() {
        System.out.println("Notidicando perda total para Seguradora...");
    }

    private void notificarReparoParaSeuradora() {
        System.out.println("Notificando reparo para Seguradora...");
    }

    private boolean veiculoParaReparo() {
        return veiculoParaReparo.getPorcentagemDano() <= 50;
    }

    private void analisarDanos() {
        System.out.println("Analisando Danos...");
    }

    private void entradaOficina() {
        System.out.println("Veiculo entrado Oficina...");
    }
}
