package main;

import implementation.SupermarkerArray;
import implementation.Supermarket;

import java.util.Scanner;
public class Main {
    private static int SIZE = 3;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Supermarket supermarker = new SupermarkerArray(SIZE);
        int opcao;
        do{
            System.out.println("\n Lista de Compras");
            System.out.println("1 - Inserir");
            System.out.println("2 - Listar");
            System.out.println("3 - Remover");
            System.out.println("4 - Sair");
            System.out.print("Escolha um opção: ");
            opcao = scanner.nextInt();

            switch (opcao){
                case 1:
                    System.out.print("Digite o item a ser inserido: ");
                    String item = scanner.next();
                    supermarker.add(item);
                    break;
                case 2:
                    supermarker.print();
                    break;
                case 3:
                    System.out.print("Digite a posição do item a ser removido: ");
                    int index = scanner.nextInt();
                    supermarker.delete(index);
                    break;
                case 4:
                    System.out.println("Saindo do programa...");
                default:
                    System.out.println("Opção inválida. Por favor, escolha novamente.");
            }
        }while (opcao != 4);

        scanner.close();
    }
}