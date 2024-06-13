package br.com.rodrigo.apolo.builder.solucao;

public class TesteAnimal {
    public static void main(String[] args) {
        Animal animal = Animal.builder()
                .nome("Rex")
                .raca("Pastor Alemão")
                .dono("Rodrigo")
                .build();

        System.out.println(animal);
    }
}
