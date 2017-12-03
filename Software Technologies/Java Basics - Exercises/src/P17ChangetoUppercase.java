import java.util.Scanner;

public class P17ChangetoUppercase {
    public static void main(String[] args) {
     Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String openTag = "<upcase>";
        String closeTag = "</upcase>";
        int indexOpenTag = input.indexOf(openTag);
        int indexCloseTag = input.indexOf(closeTag);

        while (indexOpenTag >= 0 && indexCloseTag >=0 ){
            String match = input.substring(indexOpenTag + 8, indexCloseTag).toUpperCase();
            String toBeReplaced = input.substring(indexOpenTag, indexCloseTag + 9);
            input = input.replace(toBeReplaced, match);
            indexOpenTag = input.indexOf(openTag);
            indexCloseTag = input.indexOf(closeTag);
        }

        System.out.println(input);
    }

}

