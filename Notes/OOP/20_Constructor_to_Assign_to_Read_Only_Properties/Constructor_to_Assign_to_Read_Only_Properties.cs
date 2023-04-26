using System;

namespace ConstructorToAssignToReadOnlyProperties
{
    class User
    {
        // making readonly property:
        public readonly string name;
        public string FirstName { get; } // this is also a read only properties
        // we can't set these properties from outside of the class
        // so we can only assign these value once using constructor and after that we only be able to read the value of these properties.
        public User(string n, string fn)
        {
            name = n;
            FirstName = fn;
        }
    }
    class Prog
    {
        static public void Run(string[] args)
        {
            User user = new User("Razz roman", "Roman Ojha");
            Console.WriteLine("Name: {0}, First Name: {1}", user.name, user.FirstName);

            // these will give error because we can't set the value of read only properties from outside of the class.
            // user.name = "Roman";
            // user.FirstName = "Razz";
        }
    }
}
