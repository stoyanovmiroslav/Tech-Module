import java.util.Arrays;
import java.util.Scanner;

public class P12BombNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbers = scan.nextLine().split(" ");
        String[] bombPower = scan.nextLine().split(" ");

        String bomb = bombPower[0];
        int power = Integer.parseInt(bombPower[1]);
        int index = 0;

        while (index != -1){

            index = Arrays.asList(numbers).indexOf(bomb);
            if(index < 0){
                break;
            }
        int startIndex = index - power;
        int endIndex = index + power;
        if(startIndex <= 0){
            startIndex = 0;
        }
        if (endIndex > numbers.length -1){
            endIndex = numbers.length-1;
        }
        for (int i = startIndex; i <= endIndex; i++) {
            numbers[i] = "0";
        }
       }
       int sum = 0;
        for (int i = 0; i < numbers.length; i++) {
            int num = Integer.parseInt(numbers[i]);
            sum += num;
        }
        System.out.println(sum);
    }
}
