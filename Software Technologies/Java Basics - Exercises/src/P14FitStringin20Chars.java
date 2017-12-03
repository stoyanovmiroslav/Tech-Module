import java.util.Scanner;

public class P14FitStringin20Chars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        char[] arr = input.toCharArray();

        if (arr.length < 20){
            for (int i = 0; i < arr.length; i++) {
                System.out.print(arr[i]);
            }
            for (int i = arr.length; i < 20 ; i++) {
                System.out.print("*");
            }
        }else {
            for (int i = 0; i < 20; i++) {
                System.out.print(arr[i]);
            }
        }

    }
}
