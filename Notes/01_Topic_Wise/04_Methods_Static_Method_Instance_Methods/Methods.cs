using System;

namespace Methods
{
    class Prog{
        public void Example(){
            Console.WriteLine();
            // here 'WriteLine' is the method of 'Console' class
        }

        static public void Run(string[] args){
            // Static:
            // static method can also be called as instance members
            // it can be called directly with the class name

            // for other method we have to create the instance of the class as object then call the methods
            // creating the instance using new keyword
            object test = new Object();

            // but we can't create the instance of some classes like: 'Console'

        }

        // here we are creating the method 'Main'
        // but we don't have to invoke it, it will automatically get invoke
        // static void Main(string[] args){
            // start of the program method
            // c# search of the 'Main' method to run at the start

            // To be able to call the Print method of this class we will create the object and the call the method
            // Prog myProg = new Prog();
            // myProg.Print();
        // }

        // creating simple method
        void Print(){
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }
    }
}