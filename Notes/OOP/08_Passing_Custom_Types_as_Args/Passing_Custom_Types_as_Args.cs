using System;

namespace PassingCustomTypesAsArgs
{
    class User
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            User user = new User();
            user.FirstName = "roman";
            user.LastName = "ojha";

            new Prog().takeUser(user);
        }

        public void takeUser(User user)
        {
            // here we are passing user object by reference
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.LastName);
        }

    }
}