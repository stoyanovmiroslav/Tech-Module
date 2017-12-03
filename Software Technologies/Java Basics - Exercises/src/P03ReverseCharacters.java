import java.util.Scanner;

public class P03ReverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] reversed = new String[3];
        for (int i = 2; i >= 0; i--) {
            String a =  scan.nextLine();
            reversed[i] = a;
        }
        for (int i = 0; i < 3; i++) {
            System.out.print(reversed[i]);
        }
    }
}
