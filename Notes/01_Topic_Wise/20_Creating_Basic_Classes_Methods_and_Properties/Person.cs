using System;

namespace ClassMethodPropertiesExample
{
    // Class
    public class Person
    {
        // members:
        // -> general way to describe properties, method, constructor inside class

        // properties:
        // -> store something & represent the Class object
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // customizing property to do different things
        // creating 'FullName' where if we will try to get the value of this property we will get the 'FirstName + " " + lastName';
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // method:
        // -> do something inside the class
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Field:
        // -> similar to property but it is private
        // -> property is use to access the data from the outside
        // -> field is use to store the data from the inside
        string _middleName = "Middle";
        // this field is not accessible from the outside of the class
        // convention for file is it will start with lowercase letter or with '_'
    }
}