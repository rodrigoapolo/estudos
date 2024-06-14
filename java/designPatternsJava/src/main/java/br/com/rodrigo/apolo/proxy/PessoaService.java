package br.com.rodrigo.apolo.proxy;

import br.com.rodrigo.apolo.builder.Pessoa;
import br.com.rodrigo.apolo.proxy.solucao.PessoaRepositoryProxy;
import br.com.rodrigo.apolo.proxy.solucao.ProxyPessoa;

public class PessoaService {
    private ProxyPessoa proxyPessoa;

    public PessoaService(ProxyPessoa proxyPessoa){
        this.proxyPessoa = proxyPessoa;
    }

    public void save(Pessoa pessoa){
        proxyPessoa.save(pessoa);
    }

    public Pessoa findByid(Long id){
        return proxyPessoa.findById(id);
    }
}
