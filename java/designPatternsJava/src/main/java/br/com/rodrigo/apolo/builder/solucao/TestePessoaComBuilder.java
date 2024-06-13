package br.com.rodrigo.apolo.builder.solucao;

import br.com.rodrigo.apolo.builder.Pessoa;

import java.time.LocalDate;

public class TestePessoaComBuilder {
    public static void main(String[] args) {
        Pessoa pessoa = new Pessoa.PessoaBuilder().nome("Rodrigo")
                .sobreNome("Santos")
                .documento("45248645856")
                .email("rodrigo@gmail.com")
                .apelido("apolo")
                .dataNascimento(LocalDate.of(2001, 02, 27))
                .build();

        System.out.println(pessoa);

        StringBuilder sb = new StringBuilder().append("oi").append(",tudo bem!");
        System.out.println(sb);
    }
}
