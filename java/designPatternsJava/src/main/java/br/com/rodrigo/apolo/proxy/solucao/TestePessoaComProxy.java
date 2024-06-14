package br.com.rodrigo.apolo.proxy.solucao;

import br.com.rodrigo.apolo.builder.Pessoa;
import br.com.rodrigo.apolo.proxy.PessoaRepository;
import br.com.rodrigo.apolo.proxy.PessoaService;

import java.time.LocalDate;

public class TestePessoaComProxy {
    public static void main(String[] args) {
        PessoaRepositoryProxy pessoaRepositoryProxy = new PessoaRepositoryProxy();
        NovoPessoaRepositoryProxy novoPessoaRepositoryProxy = new NovoPessoaRepositoryProxy();
        PessoaService pessoaService = new PessoaService(novoPessoaRepositoryProxy);

        Pessoa pessoa = new Pessoa.PessoaBuilder()
                .sobreNome("Piotto")
                .dataNascimento(LocalDate.of(1985, 03, 12))
                .apelido("Careca")
                .nome("Anderson")
                .documento("12648545654")
                .build();

        pessoaService.save(pessoa);

        Pessoa pessoaRetornada = pessoaService.findByid(1L);
        System.out.println(pessoaRetornada);

        Pessoa pessoaRetornadaCache = pessoaService.findByid(1L);
        System.out.println(pessoaRetornadaCache);
    }
}
