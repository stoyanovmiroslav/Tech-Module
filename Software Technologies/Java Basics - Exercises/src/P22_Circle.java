public class P22_Circle {
    private P22_Point center;
    private int radius;

    public P22_Circle(P22_Point center, int radius) {
        this.center = center;
        this.radius = radius;
    }

    public P22_Point getCenter() {
        return center;
    }

    public int getRadius() {
        return radius;
    }
}
