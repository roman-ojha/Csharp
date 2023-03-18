using System;

namespace Encapsulation
{
    /*
        *) Encapsulation:
            -> Encapsulation is defined as the wrapping up of data under a single unit. It is the mechanism that binds together code and the data it manipulates. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.
            -> Technically in encapsulation, the variables or data of a class are hidden from any other class and can be accessed only through any member function of its own class in which they are declared.
            As in encapsulation, the data in a class is hidden from other classes, so it is also known as data-hiding.
            Encapsulation can be achieved by: Declaring all the variables in the class as private and using C# Properties in the class to set and get the values of variables.

    */
    public class DemoEncap
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName = string.Empty;
        private int studentAge;

        // using accessors to get and
        // set the value of studentName
        public String Name
        {

            get { return studentName; }

            set { studentName = value; }
        }

        // using accessors to get and
        // set the value of studentAge
        public int Age
        {

            get { return studentAge; }

            set { studentAge = value; }
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            // creating object
            DemoEncap obj = new DemoEncap();

            // calls set accessor of the property Name,
            // and pass "Ankita" as value of the
            // standard field 'value'
            obj.Name = "Ankita & quot";

            // calls set accessor of the property Age,
            // and pass "21" as value of the
            // standard field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine(" Name : " + obj.Name);
            Console.WriteLine(" Age : " + obj.Age);
        }
    }
}