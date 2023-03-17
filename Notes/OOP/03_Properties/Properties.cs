using System;

namespace Properties
{
    /*
        *) Properties:
            -> properties also store information inside of an object but they have more functionality
            -> we can use property to customize the object and how it is getting store and how it is getting retrieve.
            -> A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
            -> Properties can be used as if they're public data members, but they're special methods called accessors. This feature enables data to be accessed easily and still helps promote the safety and flexibility of methods.
            -> Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
            -> A get property accessor is used to return the property value, and a set property accessor is used to assign a new value.
            -> The value keyword is used to define the value being assigned by the set or init accessor.
    */
    class Person
    {
        // creating property by just specifying the get and set
        // public property
        // here we created the public property 'Name' but here is hidden private field which this 'Name' property is associated with
        // when we use get in that case it will get the value from that field
        // when you use set in that case it will set the value from the given value to the field
        // so, NOTE that in behind the scene the property is using a private field.
        // Why should we use property then?
        // to control how the information is retrieving and how the information is getting store in that field
        public string? Name
        {
            get;
            set;
        }


    }
    class Prog
    {

        static public void Run(string[] args)
        {
        }
    }
}