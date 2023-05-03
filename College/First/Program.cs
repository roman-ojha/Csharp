using ReferenceOut;
using Inheritance;
using Constructor;
using FileHandling;
using CSharpGenerics;
using System.Collections.Generic;
using LINQ;

namespace Day1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("hello world");
            // RefOut refOut = new RefOut();
            // out
            // int a, b, sum;
            // refOut.Addition(out sum, out a, out b);
            // Console.WriteLine("{0} + {1} = {2}", a, b, sum);

            // ref
            // int m = 4, n = 6;
            // int multiply = refOut.Multiply(ref m, ref n);
            // Console.WriteLine("{0} * {1} = {2}", m, n, multiply);

            // Inheritance
            // Son son = new Son();
            // son.BaseFunction();

            // Constructor
            // Student student1 = new Student(); // default, static
            // Student student2 = new Student(); // default
            // Student p = new Student("Hello"); // parametarized
            // Student c = new Student(p); // copy constructor
            // Student c = p;

            // File Handling
            // FH fh = new FH();
            // fh.CreateFolder();
            // fh.DeleteFolder();
            // fh.CreateFile("second.txt");
            // fh.WriteIntoFile("Hello world", "second.txt");

            // Generics:
            GenericProg.CSharpGenericEx();

            // LINQ:
            Linq.Run();
        }
    }
    // indexer
    // Dictionary : System.Collection.Generic
    // Queue
    // Stack

}
