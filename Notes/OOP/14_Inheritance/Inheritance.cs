using System;

namespace Inheritance
{
    /*
        *) Inheritance:
            -> Inheritance is a mechanism in which one class acquires the property of another class.
            -> It is an important part of OOPs (Object Oriented Programming System).
            -> It is used to achieve code reusability.
            -> It is used to achieve runtime polymorphism.
            -> It is used to achieve hierarchical structure.
            -> It is used to achieve abstraction.
            -> EX: class A is the base class and class B is the derived class.
                class A
                {
                    // code
                }
                class B : A
                {
                    // code
                }
                // here class B inherits the properties and methods of class A.
            -> Different type of Inheritance are:
                1) Single Inheritance
                    -> In single inheritance, a derived class inherits the properties of a single base class.
                    -> EX: class A is the base class and class B is the derived class.
                        class A
                        {
                            // code
                        }
                        class B : A
                        {
                            // code
                        }
                2) Multilevel Inheritance
                    -> In multilevel inheritance, a derived class inherits the properties of a single base class and a derived class can also be a base class for another derived class.
                    -> EX: class A is the base class and class B is the derived class and class C is the derived class of class B.
                        class A
                        {
                            // code
                        }
                        class B : A
                        {
                            // code
                        }
                        class C : B
                        {
                            // code
                        }
                3) Hierarchical Inheritance
                    -> In hierarchical inheritance, a derived class inherits the properties of a single base class and a derived class can also be a base class for another derived class.
                        -> EX: class A is the base class and class B is the derived class and class C is the derived class of class A.
                            class A
                            {
                                // code
                            }
                            class B : A
                            {
                                // code
                            }
                            class C : A
                            {
                                // code
                            }
                4) Multiple Inheritance
                    -> In multiple inheritance, a derived class inherits the properties of multiple base classes.
                        -> EX: class A and class B are the base class and class C is the derived class of class A and class B.
                            class A
                            {
                                // code
                            }
                            class B
                            {
                                // code
                            }
                            class C : A, B
                            {
                                // code
                            }
    */
    class User
    {
        public string name = "";
        public string email = "";
        public string password = "";
        public void Login()
        {
            Console.WriteLine("User logged in");
        }
        public void Logout()
        {
            Console.WriteLine("User logged out");
        }
    }

    class Employee : User
    {
        public int salary = 0;
        public void work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Employer : User
    {
        public int noOfEmployees = 0;
        public void hire()
        {
            Console.WriteLine("Employer hired an employee");
        }
    }

    class Prog
    {

        static public void Run(string[] args)
        {
            // Calling method and properties of Employee class
            Employee employee = new Employee();
            employee.name = "razz";
            employee.email = "";
            employee.password = "";
            employee.salary = 10000;
            employee.Login();
            employee.work();
            employee.Logout();

            // Calling method and properties of Employer class
            Employer employer = new Employer();
            employer.name = "roman";
            employer.email = "";
            employer.password = "";
            employer.noOfEmployees = 10;
            employer.Login();
            employer.hire();
            employer.Logout();
        }
    }
}