using System;

namespace Abstract_Methods_and_Properties
{
    /*
        *) Abstract Methods and Properties:
            -> Abstract methods and properties are declared without an implementation.
            -> Abstract methods also allow us to override them in derived classes but we can't declare the body of the method inside base class.
            -> It means that while creating the Derived class from the base class that have abstract methods and properties that we have to override them in derived class.
            -> And Abstract methods and properties can only be declared in abstract classes.
    */

    abstract class User
    {
        // so this property is declared as an abstract property so we have to override it in derived class.
        public abstract string Name { get; set; }
        // so this method is declared as an abstract method so we have to override it in derived class.
        public abstract void Hello();
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
            // Now here we can't call the base class method 'base.Hell()' because it is declared as an abstract method and doesn't have any body or implementation.
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