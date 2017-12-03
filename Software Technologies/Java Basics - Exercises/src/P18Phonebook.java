
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class P18Phonebook {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        Map<String, String> hash = new HashMap<>();

        while (!input.equals("END")){
            String[] splitInput = input.split(" ");
            String name = splitInput[1];
            String command = splitInput[0];
            if(command.equals("A")){
                String phone = splitInput[2];
                hash.put(name, phone);

            }else if(command.equals("S")) {
                if (hash.containsKey(name)) {
                    System.out.printf("%s -> %s%n", name, hash.get(name));

                } else{
                    System.out.printf("Contact %s does not exist.%n", name);
                }
            }
            input = scan.nextLine();
        }
    }
}
