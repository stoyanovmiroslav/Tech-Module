import java.util.Scanner;

public class P10IndexofLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        char[] arr = input.toCharArray();

        for (int i = 0; i < arr.length ; i++) {
            int ascii = Character.getNumericValue(arr[i]);
            System.out.printf("%s -> %d%n", arr[i], ascii - 10);
        }
    }
}
