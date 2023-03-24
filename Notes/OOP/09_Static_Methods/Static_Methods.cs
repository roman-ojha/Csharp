using System;

namespace StaticMethods
{
    /*
        *) Static Methods
            -> Static means that is attached to the class and not to the  instance of the class or object.
            -> Static methods are methods that can be called without creating an instance of the class.
            -> Static methods are declared with the static keyword.
            -> <class_name>.<method_name> is used to call a static method.
    */
    class User{
        public string Name { get; set; }
    }
    class Prog{

        static public void Run(string[] args){
            // So here we are in the class 'Prog' and 'Run' is the main function that get called when the program starts.
            // but even having the 'Run' function inside the 'Prog' class, we can't call 'DoSomething' function without creating an instance of the class.
            // Because 'DoSomething' is the instance method and only be able to call using instance object.
            Prog p = new Prog();
            // calling 'DoSomething' function using instance object.
            p.DoSomething();
        }

        public void DoSomething(){
            Console.WriteLine("Doing Something");
        }
    }
}