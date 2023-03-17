using System;
using ClassAndObjectPerson;

namespace ClassAndObject
{

    class Prog
    {
        public static void Run(string[] args)
        {
            // object or instance of the class
            Person cls = new Person();
            cls.hello();

            // creating object of this class to call the methods
            // because this is an static method you can't be able to call the other instance member function of this class without creating object
            Prog prog = new Prog();
            prog.doSomething();
        }

        public void abc()
        {
        }

        public void doSomething()
        {

        }
    }
}