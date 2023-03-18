using System;

namespace Fields
{
    /*
        *) Fields:
            -> help to store information into the class
            -> it is a class level variable
            -> you use Field only for variable that have private or protected accessibility.
            -> by standard public field is declare starting from Capital letter EX:
                -> public string Name
            -> by standard private field is declare starting from '_' symbol EX:
                -> private DateTime _date;
            -> in most of the cases we use field for the private

    */
    class Person
    {
        // public field:
        public string? Name;
        // private field:
        private int _id = 10;

        private string? _firstName = "roman";

        public string getInfo()
        {
            return "id: " + _id + "First Name: " + _firstName;
        }
    }
    class Prog
    {
        static public void Run(string[] args)
        {
            Person person = new Person();
            // assigning value to public field  
            person.Name = "roman";
        }
    }
}