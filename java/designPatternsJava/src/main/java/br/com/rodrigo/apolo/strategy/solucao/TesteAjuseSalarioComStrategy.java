package br.com.rodrigo.apolo.strategy.solucao;

import br.com.rodrigo.apolo.strategy.Funcionario;
import br.com.rodrigo.apolo.strategy.TipoContratacaoEnum;
import br.com.rodrigo.apolo.strategy.problema.ReajusteAnualSalario;

import java.math.BigDecimal;

public class TesteAjuseSalarioComStrategy {
    public static void main(String[] args) {
        ReajusteAnualSalarioComStrategy reajusteAnualSalario = new ReajusteAnualSalarioComStrategy();
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

        Funcionario funcionariocCooperativa = new Funcionario();
        funcionariocCooperativa.setNome("João");
        funcionariocCooperativa.setTipoContratacaoEnum(TipoContratacaoEnum.COOPERATIVA);
        funcionariocCooperativa.setSalario(new BigDecimal(8000));

        //calcular nossos reajustes aqui
        reajusteAnualSalario.calculaRejusteAnual(funcionarioCLT, new CalculadorReajusteAnualSalarioCLT());
        reajusteAnualSalario.calculaRejusteAnual(funcionarioPJ, new CalculadorReajusteAnualSalarioPJ());
        reajusteAnualSalario.calculaRejusteAnual(funcionarioEstagio, new CalculadorReajusteAnualSalarioEstagio());
        reajusteAnualSalario.calculaRejusteAnual(funcionariocCooperativa, new CalculadorReajusteAnualSalarioCooperativa());

        System.out.println(funcionarioCLT);
        System.out.println(funcionarioPJ);
        System.out.println(funcionarioEstagio);
        System.out.println(funcionariocCooperativa);
    }
}
