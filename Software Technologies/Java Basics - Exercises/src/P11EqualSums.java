import java.util.Arrays;
import java.util.Scanner;

public class P11EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] numbers = Arrays.stream(scan.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        int leftSide = 0;
        int rightSide = 0;
        for (int i = -1; i < numbers.length; i++) {
            if(i >= 0){
                leftSide += numbers[i];
            }
            for (int j = i + 2; j < numbers.length; j++) {
                rightSide += numbers[j];
            }
            if (leftSide == rightSide){
                System.out.println(i+1);
                return;
            }else {
                rightSide = 0;
            }

        }
        System.out.println("no");
    }
}
