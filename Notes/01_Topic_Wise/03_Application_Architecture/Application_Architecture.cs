using System;
// if we want to use another name space from this project in different files then we can use 'using' to include that namespace with it's class into this file
// here we are using 'System' namespace
// inside the 'System' we have multiple class
// one of them is 'Console' class

namespace ApplicationArchitecture // a namespace - organization structure
{
    // namespace:
    // use for organization
    // use to group classes
    // namespace -have-> classes -have-> members -like-> methods -have-> statements

    class Prog{ // class - hah members (such as method)
        static public void Run(string[] args){ // method
            Console.WriteLine("Hello roman"); // statement
            Console.WriteLine("Best friend!"); // statement


            // we can call Console class with namespace like this
            System.Console.WriteLine("");
            // this is called as fully qualfied name
        }

        // static void Main(string[] args){
            // all of you c# executable need a Main method
            // this is where program starts 
        // }
    }
}