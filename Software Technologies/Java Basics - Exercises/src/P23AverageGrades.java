import java.text.DecimalFormat;
import java.util.*;

public class P23AverageGrades {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int numberOfStudents = Integer.parseInt(scan.nextLine());
        ArrayList<P23_Students> listStudents = new ArrayList<>();
        for (int i = 0; i < numberOfStudents ; i++) {
          String[] studentAndGrades = scan.nextLine().split(" ");
          String name = studentAndGrades[0];
          double[] grades = new double[studentAndGrades.length-1];
          double sum = 0;
            for (int j = 0; j < grades.length ; j++) {
                grades[j] = Double.parseDouble(studentAndGrades[j + 1]);
                sum += grades[j];
            }
            double avarege = sum / grades.length;
            P23_Students student = new P23_Students(name, grades, avarege);
            if(avarege >= 5.00){
                listStudents.add(student);
            }
        }
        Collections.sort(listStudents, new Comparator<P23_Students>() {
            @Override
            public int compare(P23_Students s1, P23_Students s2) {
                int sComp = s1.getName().compareToIgnoreCase(s2.getName());
                if(sComp != 0){
                    return sComp;
                }else {
                    return Double.compare(s2.getAverageGrare(),s1.getAverageGrare());
                }
            }
        });

        for (P23_Students listStudent : listStudents) {
            double grades = listStudent.getAverageGrare();
            DecimalFormat df = new DecimalFormat("#.00");

            System.out.println(listStudent.getName() + " -> " + df.format(grades));
        }
    }
}
