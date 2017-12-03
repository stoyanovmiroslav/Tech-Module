import java.text.*;
import java.util.*;

public class P25BookLibraryModification {
    public static void main(String[] args) throws ParseException {
        Scanner scan = new Scanner(System.in);
        DateFormat df = new SimpleDateFormat("dd.MM.yyyy");

        int number = Integer.parseInt(scan.nextLine());
        ArrayList<P25_Library> listLibraty = new ArrayList<>();

        for (int i = 0; i < number; i++) {
            String[] input = scan.nextLine().split(" ");
            String title = input[0];
            Date date = df.parse(input[3]);
            P25_Library library = new P25_Library(title, date);
            listLibraty.add(library);
        }
          Date startDate = df.parse(scan.nextLine());

        Collections.sort(listLibraty, new Comparator<P25_Library>() {
            @Override
            public int compare(P25_Library s1, P25_Library s2) {
                int sComp = s1.getDate().compareTo(s2.getDate());
                if(sComp != 0){
                    return sComp;
                }else {
                    return s1.getTitle().compareToIgnoreCase(s2.getTitle());
                }
            }
        });

        for (P25_Library entry : listLibraty) {
            int sComp = entry.getDate().compareTo(startDate);
            if (sComp > 0) {
                System.out.println(MessageFormat.format("{0} -> {1}", entry.getTitle(), df.format(entry.getDate())));
            }
        }
    }
}