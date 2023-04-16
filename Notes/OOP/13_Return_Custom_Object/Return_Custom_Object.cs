using System;

namespace ReturnCustomObject
{
    class User
    {
        public string? Name { get; set; }

        // Here we are returning the object of the User class if the user is found
        public static User? SearchUser(List<User> users, string name)
        {
            foreach (User user in users)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }
            return null;
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            // List of users
            List<User> users = new List<User>(){
                new User(){Name = "John"},
                new User(){Name = "Mary"},
                new User(){Name = "Peter"},
                new User(){Name = "Jane"},
                new User(){Name = "Mark"},
                new User(){Name = "Sara"},
            };

            // Search for the user
            User? user = User.SearchUser(users, "Peter");
            if (user != null)
            {
                Console.WriteLine($"User found: {user.Name}");
            }
            else
            {
                Console.WriteLine("User not found");
            }

        }
    }
}