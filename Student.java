package models;

public class Student {
    private String id;
    private String name;
    private float grade;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getGrade() {
        return grade;
    }

    public void setGrade(float grade) {
        this.grade = grade;
    }

    public Student(String id, String name, float grade) {
        this.id = id;
        this.name = name;
        this.grade = grade;
    }
}
    //    //CONSTRUCTOR
//    public Student(String id, String name, float grade)
//    {
//        this.id = id;
//        this.name = name;
//        this.grade = grade;
//    }
//    //READ
//    public String getId()
//    {
//        return id;
//    }
//    public String getName() {
//        return name;
//    }
//    public float getGrade() {
//        return grade;
//    }
//    //WRITE
//    public void Setid(String id) {
//        this.id = id;
//    }
//    public void Setname(String name) {
//        this.name = name;
//    }
//    public void Setgrade(float grade) {
//        this.grade = grade;
//    }

