using System;

namespace ClassMethodPropertiesExample
{

    class Prog{

        static public void Run(string[] args){
            // creating object of type Person
            Person person = new Person();
            person.FirstName = "roman";
            person.LastName = "ojha";
            Console.WriteLine(person.GetFullName());
        }
    }
}