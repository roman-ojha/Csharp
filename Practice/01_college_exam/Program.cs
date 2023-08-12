using System.Net.Security;

namespace CollegeExam
{

    class Program
    {
        static public void Main(string[] args)
        {

            // Data Type ============
            Console.WriteLine("Hello World");
            System.Console.Write("This is from Roman\n");
            int num1 = 10;
            uint num2 = 20;
            uint num = (uint)num1 + num2;
            Console.WriteLine(num);
            double a = 1.1;
            short b = 23;
            char c = 'R';
            string name = "Roman";
            float price = 30000.00432F;
            decimal d = 30.4M;
            bool isUser = true;
            object obj = isUser;
            double dou = double.NaN;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(double.IsInfinity(Math.Pow(99, 9999)));
            Console.WriteLine('\t');
            name += " Ojha";
            char[] name2 = { 'r', 'o', 'm', 'a', 'n' };
            string name3 = new string(name2);
            Console.WriteLine(name+name3);
            Console.WriteLine(name2.Length);
            // String literals
            string message = """ 
                \\ This is the message
                """;
            Console.WriteLine(message);
            // String Interpolation
            string name4 = $"{name3} Ojha";
            Console.WriteLine(name4);
        }
    }
}