namespace Constructor
{
    /*
      *) Constructor:
        -> A special type of method
        -> Automatically call when instance of class created
        *) Type:
          1. Default constructor
          2. Parametarized Constructor
          3. Copy Constructor
          4. Private
          5. Static
    */
    class Student
    {
        // Default Constructor
        public Student()
        {
            Console.WriteLine("This is a default constructor");
        }
        // Parameterized constructor
        public Student(string message)
        {
            Console.WriteLine(message);
        }
        // Static Constructor
        // only get called one time on you whole program after initializing the object
        static Student()
        {
            Console.WriteLine("This is a static constructor.");
        }
        // Private Constructor
        private Student(int a)
        {
            Console.WriteLine("This is a private constructor");
        }
        // Copy constructor
        public Student(Student s)
        {
        }
    }
}
