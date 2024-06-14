package br.com.rodrigo.apolo.proxy.solucao;

import br.com.rodrigo.apolo.builder.Pessoa;

public interface ProxyPessoa {
    void save(Pessoa pessoa);
    Pessoa findById(Long id);
}
