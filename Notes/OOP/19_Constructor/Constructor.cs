using System;

namespace Constructor
{
    /*
        *) Constructor:
            -> A constructor is a special method of a class or structure in object-oriented programming that initializes an object of that type.
            -> A constructor is a method whose name is the same as the name of its type. Its method signature includes only the method name and its parameter list; it does not include a return type.
            -> A constructor get called when an object of a class is created.
            -> When we will create a custom constructor, the default constructor will not be available.
            -> Different types of constructors in C#:
                - Default Constructor
                - Parameterized Constructor
                - Copy Constructor
                - Static Constructor
                - Private Constructor
    */
    class Student
    {
        public int id;
        public string name;
        // public Student(int i, string n)
        // {
        //     id = i;
        //     name = n;
        // }

        // Default constructor:
        public Student()
        {
            id = 1;
            name = "Default";
            Console.WriteLine("Default Constructor");
        }
        // Parameterized constructor:
        public Student(int i, string n)
        {
            id = i;
            name = n;
            Console.WriteLine("Parameterized Constructor");
        }
        // Copy constructor:
        public Student(Student s)
        {
            id = s.id;
            name = s.name;
            Console.WriteLine("Copy Constructor");
        }
        // Static constructor:
        static Student()
        {
            // this constructor will only get called once when the class is loaded for the first time in the memory and after that whenever we will create an object of the class, only the default constructor will get called.
            Console.WriteLine("Static Constructor");
        }
        // Private constructor:
        private Student(int i)
        {
            // This is the constructor which can only be called from inside the class.
            id = i;
            name = "Roman";
            Console.WriteLine("Private Constructor");
        }
        // function that call the private constructor:
        public static Student CreateStudent(int i)
        {
            Student s = new Student(i);
            return s;
        }

        public void display()
        {
            Console.WriteLine("ID: {0}, Name: {1}", id, name);
        }
    }

    class Prog
    {
        static public void Run(string[] args)
        {
            Student s1 = new Student(); // default constructor
            Student s2 = new Student(2, "Roman"); // parameterized constructor
            Student s3 = new Student(s2); // copy constructor
            Student s4 = Student.CreateStudent(4); // private constructor
            s1.display();
        }
    }
}