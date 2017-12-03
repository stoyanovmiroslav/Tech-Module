import java.util.Scanner;

public class P02BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();

        boolean trueOfFalse = Boolean.parseBoolean(str);
        if (trueOfFalse){
            System.out.println("Yes");
        }else {
            System.out.println("No");
        }
    }
}
