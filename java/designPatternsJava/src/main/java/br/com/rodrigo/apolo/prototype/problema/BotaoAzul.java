package br.com.rodrigo.apolo.prototype.problema;

import br.com.rodrigo.apolo.prototype.Botao;
import br.com.rodrigo.apolo.prototype.TipoBordaEnum;

public class BotaoAzul extends Botao {
    public BotaoAzul(){
        setCor("Azul");
        setAltura(35);
        setLargura(125);
        setTipoBorda(TipoBordaEnum.TRACEJADA);
    }
}
