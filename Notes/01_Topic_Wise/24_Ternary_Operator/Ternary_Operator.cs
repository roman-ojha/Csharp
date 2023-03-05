using System;

namespace TernaryOperator
{
    class Prog
    {

        static public void Run(string[] args)
        {
            // Ternary Operator also called as Conditional operator
            // <expression> ? <true_statement> : <false_statement>
            bool is_male = true;
            string name = is_male ? "Roman" : "Sita";
            Console.WriteLine(name);
        }
    }
}