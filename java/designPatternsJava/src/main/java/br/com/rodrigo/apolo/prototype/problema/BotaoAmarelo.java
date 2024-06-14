package br.com.rodrigo.apolo.prototype.problema;

import br.com.rodrigo.apolo.prototype.Botao;
import br.com.rodrigo.apolo.prototype.TipoBordaEnum;

public class BotaoAmarelo extends Botao {
    public BotaoAmarelo(){
        setCor("Amarelo");
        setAltura(40);
        setLargura(100);
        setTipoBorda(TipoBordaEnum.TRACEJADA);
    }
}
