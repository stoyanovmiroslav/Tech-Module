import java.util.Scanner;

public class P04VowelorDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        char letter = input.charAt(0);

        if(Character.isDigit(letter)){
            System.out.println("digit");
        }else if(letter == 'a' ||letter == 'e' || letter == 'i' || letter =='o' || letter =='u'){
            System.out.println("vowel");
        }else{
            System.out.println("other");
        }

    }
}
