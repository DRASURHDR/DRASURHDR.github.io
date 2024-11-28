import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        LinkedList studentList = new LinkedList();
        Scanner scanner = new Scanner(System.in);

        while (true) {
            try {
                System.out.println("\nOptions:");
                System.out.println("1: Thêm sinh viên");
                System.out.println("2: Cập nhật thông tin sinh viên");
                System.out.println("3: Xóa sinh viên");
                System.out.println("4: In ra thông tin sinh viên");
                System.out.println("5: Sort Students by Point (Ascending)");
                System.out.println("6: Sort Students by Point (Bubble Sort)");
                System.out.println("7: Phân loại điểm sinh viên");
                System.out.println("8: Thoát");

                System.out.print("Vui lòng chọn 1 lựa chọn: ");
                int choice = Integer.parseInt(scanner.nextLine().trim());

                switch (choice) {
                    case 1:
                        int id;
                        while (true) {
                            try {
                                System.out.print("Nhập mã sinh viên: ");
                                id = Integer.parseInt(scanner.nextLine().trim());
                                break;
                            } catch (NumberFormatException e) {
                                System.out.println("ID không hợp lệ. Vui lòng nhập  (chỉ nhập chữ số) .");
                            }
                        }

                        System.out.print("Nhập tên sinh viên: ");
                        String name;
                        while (true) {
                            name = scanner.nextLine().trim();
                            if (name.matches("[a-zA-Z ]+")) {
                                break;
                            } else {
                                System.out.println("Tên không hợp lệ. Vui lòng nhập lại (chỉ nhập chữ cái): ");
                            }
                        }

                        double point;
                        while (true) {
                            try {
                                System.out.print("Nhập điểm sinh viên: ");
                                point = Double.parseDouble(scanner.nextLine().trim());
                                if (point >= 0 && point <= 10) {
                                    break;
                                } else {
                                    System.out.println("Điểm không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                                }
                            } catch (NumberFormatException e) {
                                System.out.println("Điểm không hợp lệ. Vui lòng nhập lại (chỉ nhập số).");
                            }
                        }

                        studentList.addStudent(id, name, point);
                        break;



                    case 2:
                        try {
                            System.out.print("Nhập mã sinh viên mà bạn muốn cập nhật: ");
                            int updateId = Integer.parseInt(scanner.nextLine().trim());

                            System.out.print("Cập nhật tên mới: ");
                            String newName = scanner.nextLine().trim();

                            System.out.print("Cập nhật điểm mới: ");
                            double newPoint = Double.parseDouble(scanner.nextLine().trim());

                            studentList.updateStudent(updateId, newName, newPoint);
                        } catch (NumberFormatException e) {
                            System.out.println("Dữ liệu nhập không hợp lệ. Vui lòng thử lại.");
                        }
                        break;

                    case 3:
                        try {
                            System.out.print("Nhập mã sinh viên mà bạn muốn xóa: ");
                            int deleteId = Integer.parseInt(scanner.nextLine().trim());
                            studentList.deleteStudent(deleteId);
                        } catch (NumberFormatException e) {
                            System.out.println("Dữ liệu nhập không hợp lệ. Vui lòng thử lại.");
                        }
                        break;

                    case 5:
                        studentList.sortByGPAAscending();
                        System.out.println("Danh sách sinh viên đã được sắp xếp tăng dần theo điểm.");
                        studentList.displayStudents();
                        break;

                    case 6:
                        studentList.sortByGPADescendingBubbleSort();
                        System.out.println("Danh sách sinh viên đã được sắp xếp giảm dần theo điểm .");
                        studentList.displayStudents();
                        break;

                    case 7:
                        studentList.classifyStudents();
                        break;

                    case 8:
                        System.out.println("Đã thoát chương trình.");
                        scanner.close();
                        System.exit(0);

                    default:
                        System.out.println("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 7.");
                }
            } catch (NumberFormatException e) {
                System.out.println("Dữ liệu nhập không hợp lệ. Vui lòng nhập một số có trong lựa chọn.");
            } catch (Exception e) {
                System.out.println("Lỗi không mong muốn xảy ra: " + e.getMessage());
            }
        }
    }
}