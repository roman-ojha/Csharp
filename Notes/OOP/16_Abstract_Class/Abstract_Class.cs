using System;

namespace Abstract_Class
{
    /*
        *) Abstract Class:
            -> Abstract class is a class that is declared with the abstract keyword.
            -> Abstract class cannot be instantiated in another word we can't create an object of abstract class.
            -> an abstract class is a class that cannot be instantiated. Instead, it serves as a base class for other classes to inherit from.
            -> Abstract classes are used to define a common set of behaviors or properties that derived classes should have.
    */

    //  Creating 'User' class as an abstract class:
    abstract class User
    {
        public virtual string Name { get; set; } = "";
        public virtual void Hello()
        {
            Console.WriteLine("Hello I Am User And My name is {0}", Name);
        }
        public void Hi()
        {
            Console.WriteLine("Hi I Am User And My name is {0}", Name);
        }
    }

    class Student : User
    {
        private string _name = "";
        public override string Name
        {
            get => _name;
            set => _name = value;
        }

        public override void Hello()
        {
            base.Hello();
            Console.WriteLine("Hello I am Student And My name is {0}", Name);
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            Student student = new Student();
            student.Name = "Razz roman";
            student.Hello();
        }
    }
}