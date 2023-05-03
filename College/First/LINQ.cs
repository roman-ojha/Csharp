using System.Linq;
using System;
namespace LINQ
{
    /*
      *) LINQ:
        -> Language Independent query
     */
    class Student
    {
        public string Address { get; set; }
        public string College { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string a, string c, string f, string l)
        {
            Address = a; ;
            College = c;
            FirstName = f;
            LastName = l;
        }

    }
    class Linq
    {
        static public void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var allResult = from a in arr
                            select a;
            var evenResult = from a in arr
                             where a % 2 == 0
                             select a;
            Console.WriteLine(allResult);
            Console.WriteLine(evenResult);

            // (1) WAP to get the students details whose address is kathmandu and college is hcoe and order by firstname as ascending using LINQ.
            Console.WriteLine();
            List<Student> students = new List<Student>();
            Student s1 = new Student("Kathmandu", "HCOE", "Roman", "Ojha");
            students.Add(s1);
            Student s2 = new Student("Kathmandu", "HCOE", "Sushan", "Lama");
            students.Add(s2);
            Student s3 = new Student("Kathmandu", "HCOE", "Manish", "Yadav");
            students.Add(s3);
            var sResult = from s in students
                          where s.Address == "Kathmandu" & s.College == "HCOE"
                          orderby s.FirstName descending
                          select s;

            foreach (Student s in sResult)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", s.FirstName, s.LastName, s.Address, s.College);
            }
        }
    }
}
