import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int count = scan.nextInt();
        int sum = 0;
        for (int i = 0; i < count; i++) {
            int numbers = scan.nextInt();
            sum += numbers;
        }
        System.out.printf("Sum = %d",sum);
    }
}
