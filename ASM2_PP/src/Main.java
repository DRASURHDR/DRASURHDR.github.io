import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

public class Main {

    static List<Student> studentList = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("1. Nhập thông tin sinh viên");
            System.out.println("2. In danh sách sinh viên");
            System.out.println("3. Xóa sinh viên theo mã code");
            System.out.println("4. Sắp xếp sinh viên theo thứ tự điểm giảm dần");
            System.out.println("5. Tìm kiếm sinh viên theo mã hoặc tên");
            System.out.println("6. Tìm kiếm sinh viên có điểm >= x");
            System.out.println("7. Thoát");

            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            switch (choice) {
                case 1:
                    input();
                    break;
                case 2:
                    output();
                    break;
                case 3:
                    System.out.println("Nhập mã sinh viên để xóa:");
                    String code = scanner.nextLine();
                    removeByCode(code);
                    break;
                case 4:
                    sortByGradeDesc();
                    output();
                    break;
                case 5:
                    System.out.println("Nhập mã hoặc tên sinh viên để tìm:");
                    String keyword = scanner.nextLine();
                    Student foundStudent = findByCodeOrName(keyword);
                    if (foundStudent != null) {
                        System.out.println("Tìm thấy sinh viên: " + foundStudent);
                    } else {
                        System.out.println("Không tìm thấy sinh viên nào.");
                    }
                    break;
                case 6:
                    System.out.println("Nhập giá trị điểm x:");
                    float x = scanner.nextFloat();
                    List<Student> filteredStudents = filterByGrade(x);
                    System.out.println("Sinh viên có điểm >= " + x + ":");
                    for (Student student : filteredStudents) {
                        System.out.println(student);
                    }
                    break;
                case 7:
                    System.out.println("Thoát chương trình.");
                    return;
                default:
                    System.out.println("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
            }
        }
    }

    // Nhập mới một sinh viên
    public static void input() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Nhập mã sinh viên:");
        String code = scanner.nextLine();
        System.out.println("Nhập tên sinh viên:");
        String name = scanner.nextLine();
        System.out.println("Nhập tuổi sinh viên:");
        int age = scanner.nextInt();
        scanner.nextLine(); // Consume newline
        System.out.println("Nhập email sinh viên:");
        String email = scanner.nextLine();
        System.out.println("Nhập số điện thoại sinh viên:");
        String phone = scanner.nextLine();
        System.out.println("Nhập giới tính sinh viên (0: Nam, 1: Nữ):");
        int gender = scanner.nextInt();
        System.out.println("Nhập điểm sinh viên:");
        float grade = scanner.nextFloat();
        scanner.nextLine(); // Consume newline

        Student student = new Student(name, age, email, phone, code, gender, grade);
        studentList.add(student);
    }

    // In danh sách sinh viên
    public static void output() {
        for (Student student : studentList) {
            System.out.println(student);
        }
    }

    // Xóa sinh viên theo mã code
    public static void removeByCode(String code) {
        studentList.removeIf(student -> student.getCode().equals(code));
    }

    // Sắp xếp sinh viên theo thứ tự điểm giảm dần
    public static void sortByGradeDesc() {
        studentList.sort(Comparator.comparing(Student::getGrade).reversed());
    }

    // Tìm kiếm sinh viên theo mã sinh viên hoặc tên sinh viên
    public static Student findByCodeOrName(String keyword) {
        for (Student student : studentList) {
            if (student.getCode().equals(keyword) || student.getName().equalsIgnoreCase(keyword)) {
                return student;
            }
        }
        return null;
    }

    // Tìm kiếm sinh viên có điểm >= x
    public static List<Student> filterByGrade(float x) {
        List<Student> result = new ArrayList<>();
        for (Student student : studentList) {
            if (student.getGrade() >= x) {
                result.add(student);
            }
        }
        return result;
    }
}