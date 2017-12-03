import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P16URLParser {
    public static void main(String[] args) {
     Scanner scan = new Scanner(System.in);
     String[] input = scan.nextLine().split("://");
     if (input.length == 1){
         System.out.printf("[protocol] = \"\"%n");
         System.out.printf("[server] = \"%s\"%n",input[0]);
         System.out.print("[resource] = \"\"");
         return;
     }
        String protocol = input[0];
        String[] serverAndResurs = input[1].split("/");
        String server = serverAndResurs[0];
        System.out.printf("[protocol] = \"%s\"%n",protocol);
        System.out.printf("[server] = \"%s\"%n",server);

        System.out.print("[resource] = \"");
        for (int i = 1; i < serverAndResurs.length; i++) {
            if(i == serverAndResurs.length - 1){
                System.out.print(serverAndResurs[i]);
            }else {
                System.out.print(serverAndResurs[i] + "/");
            }
        }
        System.out.println("\"");
    }
}
