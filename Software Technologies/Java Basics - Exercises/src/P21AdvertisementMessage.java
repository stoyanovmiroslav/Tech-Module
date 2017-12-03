import java.util.Random;
import java.util.Scanner;

public class P21AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};
        String[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        String[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
        int n = Integer.parseInt(scan.nextLine());
        for (int i = 0; i < n ; i++) {
            Random rnd = new Random();
            int phrasesIndex = rnd.nextInt(phrases.length);
            int eventsIndex =  rnd.nextInt(events.length);
            int authorIndex = rnd.nextInt(author.length);
            int citiesIndex = rnd.nextInt(cities.length);
            System.out.printf("%s %s %s – %s%n", phrases[phrasesIndex], events[eventsIndex], author[authorIndex], cities[citiesIndex]);
        }
    }
}
