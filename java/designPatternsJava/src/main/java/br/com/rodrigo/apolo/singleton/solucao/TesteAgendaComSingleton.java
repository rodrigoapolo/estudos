package br.com.rodrigo.apolo.singleton.solucao;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;

public class TesteAgendaComSingleton {
    public static void main(String[] args) throws NoSuchMethodException, InvocationTargetException, InstantiationException, IllegalAccessException {
//        AgendaSingletonEAGER agenda1 = AgendaSingletonEAGER.getInstance();
//        AgendaSingletonEAGER agenda2 = AgendaSingletonEAGER.getInstance();
//        System.out.println(agenda1);
//        System.out.println(agenda2);
//        reservaDiaEAGER("Sexta");
//        reservaDiaEAGER("Sabado");

//        reservaDiaLAZY("Sexta");
//        reservaDiaLAZY("Sabado");
//        AgendaSingletonLAZY agenda1 = AgendaSingletonLAZY.getInstance();
//        AgendaSingletonLAZY agenda2 = AgendaSingletonLAZY.getInstance();
//        System.out.println(agenda1);
//        System.out.println(agenda2);

//        //reflection
//        Constructor<AgendaSingletonLAZY> constructorTravesso = AgendaSingletonLAZY.class.getDeclaredConstructor();
//        constructorTravesso.setAccessible(true);
//        AgendaSingletonLAZY agendaTravessa = constructorTravesso.newInstance();
//        AgendaSingletonLAZY agendaTravessa2 = constructorTravesso.newInstance();
//
//        System.out.println(agendaTravessa);
//        System.out.println(agendaTravessa2);

        reservaDiaEnum("Sexta");
        reservaDiaEnum("Sabado");
        AgendaSingletonEnum agenda1 = AgendaSingletonEnum.getInstance();
        AgendaSingletonEnum agenda2 = AgendaSingletonEnum.getInstance();
        System.out.println(agenda1.hashCode());
        System.out.println(agenda2.hashCode());

        //reflection
        Constructor<AgendaSingletonEnum> constructorTravesso = AgendaSingletonEnum.class.getDeclaredConstructor();
        constructorTravesso.setAccessible(true);
        AgendaSingletonEnum agendaTravessa = constructorTravesso.newInstance();
        AgendaSingletonEnum agendaTravessa2 = constructorTravesso.newInstance();

        System.out.println(agendaTravessa.hashCode());
        System.out.println(agendaTravessa2.hashCode());

    }

    public static void reservaDiaEAGER(String dia){
        AgendaSingletonEAGER agenda = AgendaSingletonEAGER.getInstance();
        agenda.ocupa(dia);
        System.out.println(agenda.getDias());
    }

    public static void reservaDiaLAZY(String dia){
        AgendaSingletonEAGER agenda = AgendaSingletonEAGER.getInstance();
        agenda.ocupa(dia);
        System.out.println(agenda.getDias());
    }

    public static void reservaDiaEnum(String dia){
        AgendaSingletonEnum agenda = AgendaSingletonEnum.getInstance();
        agenda.ocupa(dia);
        System.out.println(agenda.getDias());
    }
}
