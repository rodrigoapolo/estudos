package implementation;

public class SupermarkerArray implements Supermarket{
    private final String[] items;
    private int lastIndex;

    public SupermarkerArray(final int size) {
        items = new String[size];
        lastIndex = -1;
    }

    @Override
    public void add(String intem) {
        if (lastIndex == items.length-1){
            System.err.println("Lista de Supermercado cheia");
        }else {
            lastIndex++;
            items[lastIndex] = intem;
        }
    }

    @Override
    public void print() {
        System.out.println("#############################################");
        if(lastIndex < 0){
            System.out.println("Lista de Supermercardo vazia");
        }
        for(int i = 0; i <= lastIndex; i++){
            System.out.println(i + " - " + items[i]);
        }
        System.out.println("#############################################");
    }

    @Override
    public void delete(int index) {
        if (index >= 0 && index <= lastIndex){
            shift(index);
            lastIndex--;
        }else{
            System.err.println("Indice inválido " + index);
        }
    }

    private void shift(final int index) {
        for (int i = index; i < lastIndex; i++) {
            items[i] = items[i+1];
        }
    }
}
