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
            // here this is called as the auto implemented property
        }

        // assigning the empty value of it's type in property
        public string FirstName { get; set; } = string.Empty;
        // here compiler will automatically define the storage or field to store the property in backend

        // but if you want to specify the storage yourself then:
        // user defined storage for the property
        private string _firstName = string.Empty;
        public string SFirstName
        {
            // specifying what to do when
            // while getting the property value we will return the value of '_firstName' field
            get { return _firstName; }
            // while setting the value we will set the value of the property to the '_firstName' field
            set { _firstName = value; }
            // here keyword 'value' is the set accessor
        }

        // When a property implementation is a single expression, you can use expression-bodied members for the getter or setter:
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        private string _lastName = string.Empty;


        // Property validation:
        // You can write code in the set accessor to ensure that the values represented by a property are always valid. For example, suppose one rule for the Person class is that the name can't be blank or white space. You would write that as follows:
        public string VFirstName
        {
            get => _vFirstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name must not be blank");
                _vFirstName = value;
            }
            // another way:
            // set => _firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
        }
        private string _vFirstName = string.Empty;

        // Access Control in property:
        // Up to this point, all the property definitions you have seen are read/write properties with public accessors. That's not the only valid accessibility for properties. 
        // You can create read-only properties, or give different accessibility to the set and get accessors. 
        // Suppose that your Person class should only enable changing the value of the FirstName property from other methods in that class. 
        // You could give the set accessor private accessibility instead of public:
        public string? AFirstName { get; private set; }


        // Read only property:
        // You can also restrict modifications to a property so that it can only be set in a constructor. You can modify the Person class so as follows:
        public string? RFirstName { get; }


        // Todo from here:
        // https://learn.microsoft.com/en-us/dotnet/csharp/properties#init-only
    }
    class Prog
    {

        static public void Run(string[] args)
        {
        }
    }
}