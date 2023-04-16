using System;

namespace Virtual_Methods_and_Override_It
{
    /*
        *) Virtual Methods:
            -> A virtual method is a method that is declared using the virtual keyword.
            -> The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. For example, this method can be overridden by any class that inherits it.
            -> A virtual method is a member of a class that can be overridden by a derived class.
            -> When a virtual method is invoked, the run-time type of the object is checked for an overriding member. The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.
            -> By default, methods are non-virtual. You cannot override a non-virtual method.
            -> You cannot use the virtual modifier with the static, abstract, private, or override modifiers.
    */

    class User
    {
        public virtual string Name { get; set; } = "";
        public virtual void Hello()
        {
            Console.WriteLine("Hello I Am User And My name is {0}", Name);
        }

        // Note down here that if we will not put virtual keyword in front of the Hi() method then we will not be able to override it in the Student class.
        // So, if we want to override a method then we must put virtual keyword in base class methods & properties.
        public void Hi()
        {
            Console.WriteLine("Hi I Am User And My name is {0}", Name);
        }
    }

    class Student : User
    {
        private string _name = "";
        // Now here we can override the virtual properties and methods of the User class:
        public override string Name
        {
            get => _name;
            set => _name = value;
        }

        public override void Hello()
        {
            // we can also call the base class method by using base keyword:
            base.Hello();
            Console.WriteLine("Hello I am Student And My name is {0}", Name);
        }

        // Can't override the Hi() method because it is not virtual in the User class.
        // if we are creating 'Hi()' method in the Student class then it will be a new method for the Student class.
        // And if we will not create 'Hi()' method in the Student class then it will be a method of the User class.
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            User user = new User();
            user.Name = "Roman Ojha";
            user.Hello();

            Student student = new Student();
            student.Name = "Razz roman";
            student.Hello();
        }
    }
}