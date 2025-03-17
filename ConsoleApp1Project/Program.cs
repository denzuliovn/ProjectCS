using ConsoleApp1Project;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Khai bao doi tuong Student

        Student s1 = new Student();
        s1.StudentName = " Nguyen Van A";
        s1.StudentID = "UMT0001";

        // Xuat ra man hinh Console
        Console.WriteLine(s1.StudentName);

        Department d1 = new Department { DeptName = "Technical" };
        Console.WriteLine(d1.DeptName);
    }
}

class Student
{
    public string StudentID { get; set; } 
    public string StudentName { get; set; }
}