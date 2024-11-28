class LinkedList {
    private Node head;

    private class Node {
        Student student;
        Node next;

        Node(Student student) {
            this.student = student;
            this.next = null;
        }
    }

    public void addStudent(int id, String name, double point) {
        if (point < 0 || point > 10) {
            System.out.println("Điểm không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
            return;
        }

        Student newStudent = new Student(id, name, point);
        Node newNode = new Node(newStudent);

        if (head == null) {
            head = newNode;
        } else {
            Node temp = head;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        System.out.println("Thêm sinh viên thành công.");
    }



    public void updateStudent(int id, String newName, double newPoint) {
        Node temp = head;
        while (temp != null) {
            if (temp.student.getId() == id) {
                temp.student = new Student(id, newName, newPoint);
                System.out.println("Cập nhật sinh viên thành công.");
                return;
            }
            temp = temp.next;
        }
        System.out.println("Không tìm thấy sinh viên với ID: " + id);
    }


    public void deleteStudent(int id) {
        Node temp = head;
        Node prev = null;

        if (temp != null && temp.student.getId() == id) {
            head = temp.next;
            System.out.println("Xóa sinh viên thành công.");
            return;
        }

        while (temp != null && temp.student.getId() != id) {
            prev = temp;
            temp = temp.next;
        }

        if (temp == null) {
            System.out.println("Không tìm thấy sinh viên với ID: " + id);
            return;
        }

        prev.next = temp.next;
        System.out.println("Xóa sinh viên thành công.");
    }


    public void sortByGPAAscending() {
        if (head == null || head.next == null) {
            return;
        }

        Node current, index;
        for (current = head; current.next != null; current = current.next) {
            for (index = current.next; index != null; index = index.next) {
                if (current.student.getPoint() > index.student.getPoint()) {
                    // Hoán đổi dữ liệu giữa hai nút
                    Student temp = current.student;
                    current.student = index.student;
                    index.student = temp;
                }
            }
        }
        System.out.println("Sắp xếp theo điểm tăng dần thành công.");
    }


    public void sortByGPADescendingBubbleSort() {
        if (head == null || head.next == null) {
            return;
        }

        boolean swapped;
        do {
            swapped = false;
            Node current = head;
            while (current.next != null) {
                if (current.student.getPoint() < current.next.student.getPoint()) {

                    Student temp = current.student;
                    current.student = current.next.student;
                    current.next.student = temp;
                    swapped = true;
                }
                current = current.next;
            }
        } while (swapped);
        System.out.println("Sắp xếp theo điểm giảm dần thành công.");
    }


    public void displayStudents() {
        if (head == null) {
            System.out.println("Danh sách trống.");
            return;
        }

        Node temp = head;
        while (temp != null) {
            System.out.println(temp.student.toString());
            temp = temp.next;
        }
    }


    public void classifyStudents() {
        if (head == null) {
            System.out.println("Danh sách trống.");
            return;
        }

        System.out.println("Phân loại sinh viên:");
        Node temp = head;
        while (temp != null) {
            System.out.println("ID: " + temp.student.getId() + ", Name: " + temp.student.getName()
                    + ", Classification: " + temp.student.classifyPoint());
            temp = temp.next;
        }
    }
}