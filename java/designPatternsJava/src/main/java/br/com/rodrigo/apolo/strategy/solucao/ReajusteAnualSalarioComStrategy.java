package br.com.rodrigo.apolo.strategy.solucao;

import br.com.rodrigo.apolo.strategy.Funcionario;
import br.com.rodrigo.apolo.strategy.TipoContratacaoEnum;

import java.math.BigDecimal;

public class ReajusteAnualSalarioComStrategy {
    public void calculaRejusteAnual(Funcionario funcionario, CalculadorReajusteAnualSalario calculador){
        calculador.calcularReajusteAnual(funcionario);
    }
}
