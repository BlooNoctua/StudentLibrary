
namespace StudentLibrary
{
    class Student
    {   //create private fields for student info
        private int id;
        private string name;
        private int age;
        //private field for student count
        private static int studentCount = 0;

        //public properties for private fields
        public int Id
        {
            get { return id; } //get method
            private set { id = value; } //private setter makes it read-only
        }
        public string Name
        {
            get { return name; } //get method
            set { name = value; } //set method
        }
        public int Age
        {
            get { return age; } //get method
            set { age = value; } //set method
        }
        public static int StudentCount
        {
            get { return studentCount; }
            private set { studentCount = value; }
        }

        //default constructor
        public Student()
        {
            name = "John Doe";
            age = 16;
            id = studentCount++;
           
        }
        //custom constructor
        public Student(string name, int age)
            {
            this.name = name;
            this.age = age;
            id = studentCount++;
        }

        //Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {id}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Age: {age}");
        }

        public int getOlder()
        {
            age = age + 1;
            return age;
        }
    }
}
