package br.com.rodrigo.apolo.proxy.solucao;

import br.com.rodrigo.apolo.builder.Pessoa;
import br.com.rodrigo.apolo.proxy.PessoaRepository;

import java.util.HashMap;
import java.util.Map;
import java.util.Objects;
import java.util.logging.Logger;

public class PessoaRepositoryProxy extends PessoaRepository implements ProxyPessoa {

    private static Logger log = Logger.getLogger(PessoaRepositoryProxy.class.getName());
    private Map<Long, Pessoa> cache = new HashMap<>();
    @Override
    public void save(Pessoa pessoa) {
        log.info("Iniciando chamada do metodo save...");
        super.save(pessoa);
        log.info("Chamada do metodo save finalizada.");
    }

    @Override
    public Pessoa findById(Long id) {
        log.info("Iniciando chamada do metodo findById...");
        long inicia = System.currentTimeMillis();
        Pessoa pessoa = null;

        if (Objects.isNull(cache.get(id))){
            log.info("Esta pegado do cache");
            pessoa = cache.get(id);
        }else {
            log.info("Esta pegado do Pessoa Repository");
            pessoa = super.findById(id);
            cache.put(id,pessoa);
        }

        log.info("Chamada do metodo findById finalizada.");
        long fim = System.currentTimeMillis();

        log.info("Tempo gasto na chamada..." + (fim - inicia));

        return pessoa;
    }
}
