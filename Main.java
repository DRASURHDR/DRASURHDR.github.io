import models.Student;

import java.util.ArrayList;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    // Bien global
    static List<Student> studentList = new ArrayList<>();


    public static void main(String[] args)
    {
        int n;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter number of student");
        n = scanner.nextInt();
        input(n);
        System.out.println("Student info:");
        output();
        //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
        // to see how IntelliJ IDEA suggests fixing it.
//        System.out.printf("Hello and welcome!");
//        System.out.println("Hello SE07103");
//        Scanner scanner = new Scanner(System.in);
//        int a;
//        int b;
//        System.out.println("Enter a");
//        a = scanner.nextInt();
//        System.out.println("Enter b");
//        b = scanner.nextInt();
//
//        System.out.println("a + b:" + (a + b));
//        System.out.println("a - b:" + (a - b));
//        System.out.println("a x b:" + (a * b));
//        System.out.println("a / b:" + (float)(a / b));
//        if(a > b)
//        {
//            System.out.println("a greater than b");
//        }
//        else if(a < b)
//        {
//            System.out.println("b greater than a");
//        }
//        else
//        {
//            System.out.println("a equal b");
//        }
//        Student student = new Student(id:"BH000", name:"Dra", grade:"77")
//        System.out.println("Student id:" + student.getId());
    }
    //Ham nhập dữ liệu
    static void input(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        Scanner scanner = new Scanner(System.in);
        System.out.println("enter student ID");
        String id = scanner.nextLine();
        System.out.println("enter student name");
        String name = scanner.nextLine();
        System.out.println("enter student grade");
        String grade = scanner.nextLine();
      }
    }
    // Ham in du lieu
    static void output() {
        for(Student student: studentList){
            System.out.println("Student ID:" + student.getId() +
                                "Student name" + student.getName()+
                                 "Studnt grade" + student.getGrade());
        }

    }
    static void sortByGradebyDesc() {

    }
    static void findByIdStudent() {

    }
}