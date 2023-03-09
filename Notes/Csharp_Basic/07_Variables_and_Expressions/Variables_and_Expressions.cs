using System;

namespace VariablesAndExpressions
{
    class Prog{

        static public void Run(string[] args){
            // variables store some value
            string name = "roman";
            int x = 5;
            // identifier - what we call the variable like: 'x', 'name'
            // every variable have it's data type

            // now we can reference this variable where ever we want
            Console.WriteLine(x);
            Console.WriteLine(name);

            // Expression - Evaluates to a value

            Console.WriteLine(name + " is a boy");

            // Operator - it works on operands: <operands> + <operands>
            // Operand - the thing(s) that the operator works on
            // Literal - actual value
                // EX: x + " Hello"
                // " Hello" is a literal
        }
    }
}