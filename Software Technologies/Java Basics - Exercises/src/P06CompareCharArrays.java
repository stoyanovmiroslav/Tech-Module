import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class P06CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] arr1 = scan.nextLine().split(" ");
        String[] arr2 = scan.nextLine().split(" ");

        String line1 = String.join("", arr1);
        String line2 = String.join("", arr2);

        String[] arr = new String[2];
        arr[0] = line1;
        arr[1] = line2;
        Arrays.sort(arr);

        for (int i = 0; i < arr.length ; i++) {
            System.out.println(arr[i]);
        }
    }
}
