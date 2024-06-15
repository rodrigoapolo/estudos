package br.com.rodrigo.apolo.strategy.problema;

import br.com.rodrigo.apolo.strategy.Funcionario;
import br.com.rodrigo.apolo.strategy.TipoContratacaoEnum;

import java.math.BigDecimal;

public class TesteAjuseSalarioSemStrategy {
    public static void main(String[] args) {
        ReajusteAnualSalario reajusteAnualSalario = new ReajusteAnualSalario();
        Funcionario funcionarioCLT = new Funcionario();
        funcionarioCLT.setNome("Victor");
        funcionarioCLT.setTipoContratacaoEnum(TipoContratacaoEnum.CLT);
        funcionarioCLT.setSalario(new BigDecimal(5000));

        Funcionario funcionarioPJ = new Funcionario();
        funcionarioPJ.setNome("Podolski");
        funcionarioPJ.setTipoContratacaoEnum(TipoContratacaoEnum.PJ);
        funcionarioPJ.setSalario(new BigDecimal(10000));

        Funcionario funcionarioEstagio = new Funcionario();
        funcionarioEstagio.setNome("Osvaldo");
        funcionarioEstagio.setTipoContratacaoEnum(TipoContratacaoEnum.ESTAGIO);
        funcionarioEstagio.setSalario(new BigDecimal(2000));

        //calcular nossos reajustes aqui
        reajusteAnualSalario.calculaRejusteAnual(funcionarioCLT);
        reajusteAnualSalario.calculaRejusteAnual(funcionarioPJ);
        reajusteAnualSalario.calculaRejusteAnual(funcionarioEstagio);

        System.out.println(funcionarioCLT);
        System.out.println(funcionarioPJ);
        System.out.println(funcionarioEstagio);
    }
}
