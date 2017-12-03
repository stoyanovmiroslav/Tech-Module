import java.text.DecimalFormat;
import java.text.MessageFormat;
import java.util.*;

public class P24BookLibrary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = Integer.parseInt(scan.nextLine());
        ArrayList<P24_Library> listLibraty = new ArrayList<>();
        for (int i = 0; i < number; i++) {
            String[] input = scan.nextLine().split(" ");
            String author = input[1];
            double price = Double.parseDouble(input[5]);
            P24_Library library = new P24_Library(author,price);

            boolean containAuthor = true;
            for (P24_Library lib : listLibraty) {
                if (lib.getAuthor().equalsIgnoreCase(author)){
                    double oldPrice= lib.getPrice();
                    oldPrice+=price;
                    lib.setPrice(oldPrice);
                    containAuthor = false;
                }
            }
            if(containAuthor){
                listLibraty.add(library);
            }

        }

        Collections.sort(listLibraty, new Comparator<P24_Library>() {
            @Override
            public int compare(P24_Library s1, P24_Library s2) {
                int sComp = Double.compare(s2.getPrice(),s1.getPrice());
                if(sComp != 0){
                    return sComp;
                }else {
                    return s1.getAuthor().compareToIgnoreCase(s2.getAuthor());
                }
            }
        });

        for (P24_Library entry : listLibraty) {
            DecimalFormat df = new DecimalFormat("#.00");
            System.out.println(MessageFormat.format("{0} -> {1}", entry.getAuthor(), df.format(entry.getPrice())));
        }
    }
}
