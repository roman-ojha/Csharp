using System;
using System.Collections.Generic;

namespace ListOfCustomClass
{
    class Person
    {
        private string? _firstName;
        private string? _lastName;

        public string Name
        {
            get
            {
                return _firstName + " " + _lastName;
            }
            set
            {
                _firstName = value.Split(" ")[0];
                _lastName = value.Split(" ")[1];
            }
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Roman Ojha";
            Person p2 = new Person();
            p2.Name = "Razz Roman";

            // Creating list which store the type of 'Person'
            List<Person> persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            // iterating through list
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }

            // 'Person' array size of 10
            Person[] persons2 = new Person[10];
            // persons2[0].Name = "Roman Ojha";
            // persons2[1].Name = "Razz Roman";
            Person[] persons3 = { new Person(), new Person() };


            // Getting list of person info
            List<Person> persons4 = new List<Person>();
            for (int i = 0; i < 3; i++)
            {
                Person p = new Person();
                p.Name = Console.ReadLine() ?? "";
                persons4.Add(p);
            }

            // Iterating through person4 list
            foreach (Person person in persons4)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}