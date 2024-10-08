using StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        //create new object for the Student class
        Student student = new Student();
        Student student1 = new Student("Jane Doe", 18);

        Console.WriteLine("Current Students: ");
        student.DisplayInfo();
        student1.DisplayInfo();

        Console.WriteLine("Next Year: ");
        student.getOlder();
        student1.getOlder();
        student.DisplayInfo();
        student1.DisplayInfo();
    }
}