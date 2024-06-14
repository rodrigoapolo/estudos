package br.com.rodrigo.apolo.prototype.problema;

import br.com.rodrigo.apolo.prototype.Botao;
import br.com.rodrigo.apolo.prototype.TipoBordaEnum;

public class BotaoVermelho extends Botao {
    public BotaoVermelho(){
        setCor("Vermelha");
        setAltura(30);
        setLargura(100);
        setTipoBorda(TipoBordaEnum.FINA);
    }
}
