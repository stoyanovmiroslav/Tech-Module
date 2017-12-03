import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = scan.nextInt();

        for (int i = 1; i <= number ; i++) {
            String numberStr = "" + i;
            char[] array = numberStr.toCharArray();
            boolean chech = true;

            for (int j = 0; j < numberStr.length()/2  ; j++) {
                  if(array[j] != array[array.length - 1 - j]){
                     chech = false;
                  }
            }
            if (chech){
                System.out.printf("%d ",i);
            }
        }
    }
}
