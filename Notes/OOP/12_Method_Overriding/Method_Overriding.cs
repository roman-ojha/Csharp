using System;

namespace MethodOverriding
{
    /*
       *) Method Overriding:
           -> Method overriding is a feature that allows a subclass or child class to provide a specific implementation of a method that is already provided by one of its super-classes or parent classes.
           -> The implementation in the subclass overrides (replaces) the implementation in the superclass by providing a method that has the same signature as the one in the superclass.
           -> The signature of a method includes the name of the method, the number of parameters and the type of each parameter.
    */

    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("BaseClass.Print()");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Name { get; set; } = "DerivedClass";
        // inherited BaseClass class

        // Overriding the 'Print()' method of the BaseClass class
        // Now the 'Print()' method of the DerivedClass class will be called if we will call it using the object of the DerivedClass class
        // NOTE: to override the method we need to use the 'override' keyword
        // NOTE: also to override the method we need to use the 'virtual' keyword in the base class for that method
        public override void Print()
        {
            Console.WriteLine("DerivedClass.Print()");
        }

        // All the object have default methods like 'ToString()', 'Equals()', 'GetHashCode()' etc.
        // we can override these kind of methods in our class as well

        public override string ToString()
        {
            // Now here we can write our own code to return the string
            return this.Name;
        }

        public override bool Equals(object? obj)
        {
            // Now here we can write our own code to check if the object is equal or not
            // return Name == ((DerivedClass)obj).Name;
            return Name == (obj as DerivedClass)?.Name;
            // to use 'obj' we need to cast it to the DerivedClass type
        }

        // We also need to override the 'GetHashCode()' method if we override the 'Equals()' method
        // HashTable is the data structure that allows us to store the information
        // And the same this happen with the Object in C# to store the information
        // Because of that we can get the information from the object using the 'GetHashCode()' method
        // HashCode is a unique number that is assigned to each object
        // GetHashCode() method is useful when we want to store the object in the HashTable
        public override int GetHashCode()
        {
            // We can just return the default base.GetHashCode() method
            return base.GetHashCode();

            // If we will return Name.GetHashCode() then we will get the same hash code for all the objects that have to same name value if we will call the GetHashCode() method for those object
            // return Name.GetHashCode();
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Print(); // DerivedClass.Print()
            DerivedClass derivedClass2 = new DerivedClass();
            Console.WriteLine(derivedClass.Equals(derivedClass2)); // True
        }
    }
}