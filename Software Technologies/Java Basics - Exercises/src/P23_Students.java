import java.util.ArrayList;
import java.util.List;

public class P23_Students {
    private String name;
    private double[] listOfGrades;
    private double averageGrare;

    public P23_Students(String name, double[] listOfGrades, double averageGrare) {
        this.name = name;
        this.listOfGrades = listOfGrades;
        this.averageGrare = averageGrare;
    }

    public String getName() {
        return name;
    }

    public double[] getListOfGrades() {
        return listOfGrades;
    }

    public double getAverageGrare() {
        return averageGrare;
    }
}
