package br.com.rodrigo.apolo.adapter.problema;

import java.math.BigDecimal;

public class TesteOperacoesContaCorrente {
    public static void main(String[] args) {
        JarOperacoesContaCorrente jarConta = new JarOperacoesContaCorrente();
        ClientJarOperacoesContaCorrente client = new ClientJarOperacoesContaCorrente(jarConta);

        BigDecimal valorPrentendidoParaSaque = new BigDecimal(1000);

        if(client.validaSaldo(valorPrentendidoParaSaque)){
            client.saca(valorPrentendidoParaSaque);
        }

        client.deposita(new BigDecimal(500));
    }
}
