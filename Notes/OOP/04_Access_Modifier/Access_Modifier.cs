using System;

namespace AccessModifier
{
    class Person
    {
        // private field
        private int _id;

        // public field
        public string? Name;
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            Person person = new Person();
            // accessing public field & properties outside the class/ using object
            person.Name = "roman";

            // can't access private field & properties outside the class / using object
            // person._id;
        }
    }
}