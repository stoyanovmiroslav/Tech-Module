import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class P19PhonebookUpgrade {
        public static void main(String[] args) {
            Scanner scan = new Scanner(System.in);
            String input = scan.nextLine();
            TreeMap<String, String> hash = new TreeMap<>();

            while (!input.equals("END")){
                String[] splitInput = input.split(" ");

                String command = splitInput[0];
                if(command.equals("A")){
                    String name = splitInput[1];
                    String phone = splitInput[2];
                    hash.put(name, phone);

                }else if(command.equals("S")) {
                    String name = splitInput[1];
                    if (hash.containsKey(name)) {

                        System.out.printf("%s -> %s%n", name, hash.get(name));

                    } else{
                        System.out.printf("Contact %s does not exist.%n", name);
                    }
                }else if(command.equals("ListAll")){
                    for (String key : hash.keySet()) {
                        System.out.printf("%s -> %s%n", key, hash.get(key));
                    }
                }
                input = scan.nextLine();
            }
        }
    }
