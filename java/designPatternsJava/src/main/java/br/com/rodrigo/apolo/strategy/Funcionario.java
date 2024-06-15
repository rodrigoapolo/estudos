package br.com.rodrigo.apolo.strategy;

import java.math.BigDecimal;

public class Funcionario {
    private String nome;
    private BigDecimal salario;
    private TipoContratacaoEnum tipoContratacaoEnum;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public BigDecimal getSalario() {
        return salario;
    }

    public void setSalario(BigDecimal salario) {
        this.salario = salario;
    }

    public TipoContratacaoEnum getTipoContratacaoEnum() {
        return tipoContratacaoEnum;
    }

    public void setTipoContratacaoEnum(TipoContratacaoEnum tipoContratacaoEnum) {
        this.tipoContratacaoEnum = tipoContratacaoEnum;
    }

    @Override
    public String toString() {
        return "Funcionario{" +
                "nome='" + nome + '\'' +
                ", salario=" + salario +
                ", tipoContratacaoEnum=" + tipoContratacaoEnum +
                '}';
    }
}
