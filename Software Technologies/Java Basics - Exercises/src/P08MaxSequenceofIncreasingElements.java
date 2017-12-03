import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class P08MaxSequenceofIncreasingElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] numbers = Arrays.stream(scan.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        int count = 0;
        int currentCount = 1;
        int startIndex = 0;

        for (int i = 0; i < numbers.length-1; i++) {
            if(numbers[i] < numbers[i+1]){
                currentCount++;
                if(currentCount > count){
                    startIndex = (i + 1) - count;
                    count = currentCount;
                }
            }else{

                currentCount = 1;
            }
        }

        for (int i = startIndex; i < startIndex + count ; i++) {
            System.out.printf("%d ", numbers[i]);
        }

    }
}
