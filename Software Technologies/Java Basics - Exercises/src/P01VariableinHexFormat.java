import java.util.Scanner;

public class P01VariableinHexFormat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int convertedNumber = Integer.parseInt(scan.nextLine(), 16);
        System.out.println(convertedNumber);
    }
}