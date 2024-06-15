package br.com.rodrigo.apolo.strategy.problema;

import br.com.rodrigo.apolo.strategy.Funcionario;
import br.com.rodrigo.apolo.strategy.TipoContratacaoEnum;

import java.math.BigDecimal;

public class ReajusteAnualSalario {
    public void calculaRejusteAnual(Funcionario funcionario){
        if(TipoContratacaoEnum.CLT.name().equals(funcionario.getTipoContratacaoEnum().name())){
            BigDecimal salario = funcionario.getSalario();
            funcionario.setSalario(salario.add(salario.multiply(new BigDecimal((0.10)))));
        }else if(TipoContratacaoEnum.PJ.name().equals(funcionario.getTipoContratacaoEnum().name())){
            BigDecimal salario = funcionario.getSalario();
            funcionario.setSalario(salario.add(salario.multiply(new BigDecimal((0.05)))));
        }else{
            BigDecimal salario = funcionario.getSalario();
            funcionario.setSalario(salario.add(salario.multiply(new BigDecimal((0.02)))));
        }
    }
}
