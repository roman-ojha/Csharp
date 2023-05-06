using System.Linq;
using System;

namespace Lab01Q6
{
    // 6. WAP to add any five students detail and find the records whose address is lalitpur and college is kct and order by firstname descending in LINQ.
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
    class Prog
    {
        static public void Run(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("Lalitpur", "kct", "Roman", "Ojha");
            students.Add(s1);
            Student s2 = new Student("Kathmandu", "hcoe", "Roman", "Ojha");
            students.Add(s1);
            Student s3 = new Student("Lalitpur", "kct", "Sushan", "Lama");
            students.Add(s2);
            Student s4 = new Student("Lalitpur", "kct", "Manish", "Yadav");
            students.Add(s3);
            var sResult = from s in students
                          where s.Address == "Lalitpur" & s.College == "kct"
                          orderby s.FirstName descending
                          select s;

            foreach (Student s in sResult)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", s.FirstName, s.LastName, s.Address, s.College);
            }
        }
    }
}