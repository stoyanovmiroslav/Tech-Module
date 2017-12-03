import java.util.Scanner;

public class P22IntersectionofCircles {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] firstCircleData = scan.nextLine().split(" ");
        String[] secondCircleData = scan.nextLine().split(" ");

        P22_Point centerC1 = new P22_Point(Integer.parseInt(firstCircleData[0]), Integer.parseInt(firstCircleData[1]));
        P22_Circle c1 = new P22_Circle(centerC1, Integer.parseInt(firstCircleData[2]));

        P22_Point centerC2 = new P22_Point(Integer.parseInt(secondCircleData[0]), Integer.parseInt(secondCircleData[1]));
        P22_Circle c2 = new P22_Circle(centerC2, Integer.parseInt(secondCircleData[2]));

        boolean intersect = intersect(c1, c2);
        if(intersect){
            System.out.println("Yes");
        }else {
            System.out.println("No");
        }
    }

    private static boolean intersect(P22_Circle c1, P22_Circle c2) {

        double distance = Math.sqrt(Math.pow(c1.getCenter().getX() - c2.getCenter().getX(), 2) +
                Math.pow(c1.getCenter().getY() - c2.getCenter().getY(), 2));
        double radiusSum = c1.getRadius() + c2.getRadius();
        if(distance > radiusSum){
            return false;
        }else {
            return true;
        }
    }
}
