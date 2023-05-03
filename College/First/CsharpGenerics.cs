using System.Collections.Generic;

namespace CSharpGenerics
{
    class GenericProg
    {
        public static void CSharpGenericEx()
        {
            // list
            List<string> students = new List<string>() { "Roman", "Susan", "Suman", "Sivhahari", "Manish" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            // Dictionary<Key,Value>
            Dictionary<int, string> teachers = new Dictionary<int, string>();
            teachers.Add(1, "Himal");
            teachers.Add(2, "Ram");
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.Key + " " + teacher.Value);
            }

            // SortedList
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("B", "Nepal");
            sl.Add("A", "Bhutan");
            foreach (var s in sl)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }

            // Queue:
            Queue<string> qs = new Queue<string>();
            qs.Enqueue("x");
            qs.Enqueue("y");
            qs.Enqueue("z");
            foreach (var q in qs)
            {
                Console.Write(q + " | ");
            }

            // Stack:
            Stack<string> ss = new Stack<string>();
            foreach (var s in ss)
            {
                Console.Write(s + " ");
            }
        }
    }
}
