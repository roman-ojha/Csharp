namespace CallBaseClassConstructor
{
    class User
    {
        public string name;
        public string FirstName { get; }
        public User() // by default the if we are creating the object using child class constructor the default constructor of base class will be called
        {
            name = "Default";
            FirstName = "Default";
            Console.WriteLine("User Default Constructor");
        }
        public User(string n, string fn) // but in case of parameterized constructor we have to call the base class constructor explicitly
        {
            name = n;
            FirstName = fn;
            Console.WriteLine("User Constructor");
        }
    }
    class Student : User
    {
        public int age;
        public Student()
        {
            age = 0;
            Console.WriteLine("Student Default Constructor");
        }
        public Student(string n, string fn, int a) : base(ConvertToUpper(n), fn) // here we are passing the value of n and fn to the base class 'User' constructor
        {
            // firstly the base class constructor will be called and then the derived class constructor will be called
            age = a;
            Console.WriteLine("Student Constructor");
        }

        private static string ConvertToUpper(string name)
        {
            return name.ToUpper();
        }
    }
    class Prog
    {
        static public void Run(string[] args)
        {
            // creating object using default constructor
            Student s1 = new Student();

            Student s2 = new Student("john", "Doe", 20);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.FirstName);
            Console.WriteLine(s2.age);
        }
    }
}
