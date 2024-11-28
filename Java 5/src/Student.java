class Student {
    private int id;
    private String name;
    private double point;

    public Student(int id, String name, double point) {
        this.id = id;
        this.name = name;
        this.point = point;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public double getPoint() {
        return point;
    }

    public String classifyPoint() {
        if (point >= 9.0) {
            return "Xuất sắc";
        } else if (point >= 8.0) {
            return "Giỏi";
        } else if (point >= 6.5) {
            return "Khá";
        } else if (point >= 5.0) {
            return "Trung bình";
        } else {
            return "Trượt";
        }
    }

    @Override
    public String toString() {
        return "ID: " + id + ", Name: " + name + ", Point: " + point + ", Classification: " + classifyPoint();
    }
}