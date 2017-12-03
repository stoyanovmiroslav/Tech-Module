import java.util.Scanner;

public class P13ReverseString {
        public static void main(String[] args) {
            Scanner scan = new Scanner(System.in);
            String input = scan.nextLine();
            char[] arr = input.toCharArray();

            for (int i = arr.length - 1; i >= 0; i--) {
                System.out.print(arr[i]);
            }
        }
}