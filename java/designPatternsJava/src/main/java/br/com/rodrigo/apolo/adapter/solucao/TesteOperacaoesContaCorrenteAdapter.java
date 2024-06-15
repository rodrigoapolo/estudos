package br.com.rodrigo.apolo.adapter.solucao;

import br.com.rodrigo.apolo.adapter.problema.JarOperacoesContaCorrente;

import java.math.BigDecimal;

public class TesteOperacaoesContaCorrenteAdapter {
    public static void main(String[] args) {
        JarOperacoesContaCorrente jarConta = new JarOperacoesContaCorrente();
        JarOperacoesContaCorrenteAdapter jarContaAdapter = new JarOperacoesContaCorrenteAdapter(jarConta);
        ClientJarOperacoesContaCorrenteAdapter client = new ClientJarOperacoesContaCorrenteAdapter(jarContaAdapter);

        BigDecimal valorPrentendidoParaSaque = new BigDecimal(1000);


        client.saca(valorPrentendidoParaSaque);


        client.deposita(new BigDecimal(500));
    }
}
