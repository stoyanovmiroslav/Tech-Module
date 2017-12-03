import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class SumsbyTown {
    public static void main(String[] args) {
        Scanner scan  = new Scanner(System.in);
        int numbers = Integer.parseInt(scan.nextLine());
        TreeMap<String, Double> hash = new TreeMap<>();


        for (int i = 0; i < numbers ; i++) {
            String cons = scan.nextLine();
            String[] input  = cons.split("\\|");

            String town = input[0].trim();
            double income = Double.parseDouble(input[1].trim());
            if(!hash.containsKey(town)){
                hash.put(town, income);
            }else {
                hash.put(town, hash.get(town) + income);
            }
        }
        for (String key: hash.keySet()) {
            System.out.println(key + " -> " + hash.get(key));
        }

    }
}
