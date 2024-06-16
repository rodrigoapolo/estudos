package br.com.rodrigo.apolo.templatemethod.solucao;

public abstract class ReparoVeiculoService {
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

    protected abstract boolean veiculoParaReparo();

    private void analisarDanos() {
        System.out.println("Analisando Danos...");
    }

    private void entradaOficina() {
        System.out.println("Veiculo entrado Oficina...");
    }
}
