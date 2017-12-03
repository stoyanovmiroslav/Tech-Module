import java.util.Arrays;
import java.util.Scanner;

public class Largest3Numbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
       int[] numbers = Arrays.stream(scan.nextLine()
               .split(" "))
               .mapToInt(Integer::parseInt)
               .toArray();

        Arrays.sort(numbers);

        for (int i = numbers.length -1 ; i > numbers.length -4; i--) {
            if(i >= 0){
                System.out.println(numbers[i]);
            }
        }
    }
}
