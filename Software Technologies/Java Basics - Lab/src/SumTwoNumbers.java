import java.math.BigInteger;
import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {


        Scanner scanner = new Scanner(System.in);
        double firstNumber = Double.parseDouble(scanner.nextLine());
        double secondNumber = Double.parseDouble(scanner.nextLine());
        double sum = firstNumber + secondNumber;
        System.out.printf("%.2f",sum);
    }


}

