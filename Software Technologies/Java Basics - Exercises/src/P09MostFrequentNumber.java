    import java.util.Arrays;
    import java.util.Scanner;

    public class P09MostFrequentNumber {
        public static void main(String[] args) {
            Scanner scan = new Scanner(System.in);
            int[] numbers = Arrays.stream(scan.nextLine()
                    .split(" "))
                    .mapToInt(Integer::parseInt)
                    .toArray();
            int count = 0;
            int currentCount = 1;
            int number = 0;

            for (int i = 0; i < numbers.length; i++) {
                for (int j = 0; j < numbers.length ; j++) {
                    if(numbers[j] == numbers[i]){
                        if(j != i){
                            currentCount++;
                            if(currentCount > count){
                                count = currentCount;
                                number = numbers[i];
                            }
                        }
                    }
                }
                currentCount = 1;
            }
            if(count == 0){
                System.out.printf("%d ", numbers[0]);
            }else{
                System.out.printf("%d ", number);
            }

        }
    }
