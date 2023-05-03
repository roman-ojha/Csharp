namespace InterfaceExample
{
    /*
      *) Interface:
        -> An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface.
        -> The class define what an object is where as interface define what a class can do.
        -> An interface may define a default implementation for members. It may also define static members in order to provide a single implementation for common functionality.
        -> Beginning with C# 11, an interface may define static abstract or static virtual members to declare that an implementing type must provide the declared members.
        -> Typically, static virtual methods declare that an implementation must define a set of overloaded operators.
    */

    interface IUser // here we will define the User Inteface where we will define the methods that the class will implement.
    {
        public string Name { get; set; }
        public int Id { get; set; }
        void Print();
    }

    class User : IUser // here we will implement the IUser interface.
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public User(int id, string name)
        {
            Name = name;
            Id = id;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} Id: {Id}");
        }
        public void Print2()
        {
            Console.WriteLine($"Name: {Name} Id: {Id}");
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            User user = new User(1, "Roman Ojha");
            user.Print();

            // Now the classes that implements the interface you can trust them to act in a certain way.
            // So we can create the new Instance of an User class by use the IUser interface type.
            // So if we will try to assing the certain object to an interface type and if that works then it means that the object implements the interface.
            IUser u = new User(2, "Roman Ojha");
            // so here 'IUser' works as a type but it is an interface and we can't create an instance of an interface so we have to create an instance of class that implement that interface.
            // but as define we can't access the methods that are not defined in the interface but implemented in the class.
            // so to solve that problem we have to cast the object to the class type.
            ((User)u).Print2();
        }
    }
}
