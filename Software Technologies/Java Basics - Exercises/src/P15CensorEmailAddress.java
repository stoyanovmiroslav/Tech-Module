import java.util.Scanner;

public class P15CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String email = scan.nextLine();
        String text = scan.nextLine();
        String[] splitEmail = email.split("@");
        String stars = "";
        for (int i = 0; i < splitEmail[0].length(); i++) {
            stars = stars + "*";
        }
        String toReplace = stars + "@" + splitEmail[1];

        String replacedString = text.replaceAll(email, toReplace);
        System.out.println(replacedString);
    }
}
