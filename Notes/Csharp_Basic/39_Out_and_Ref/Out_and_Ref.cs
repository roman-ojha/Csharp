using System;

namespace OutAndRef
{
    /*
        *) Out and Ref
            -> Out and Ref are used to pass arguments by reference
            -> we can pass the out and ref as arguments inside the function and if we change the value of those passed arguments inside the function then the value of those arguments that we passed will get changed at the scope where we passed those arguments
            -> We can use this feature if we want to return more than one output from a function
            -> Or we want to modify a parameter and return back the modified parameter to the caller
            -> Generally, when we pass parameters to method, they are passed as a value
            -> But when we use ref and out parameter the parameter are passed as a reference.
            -> When we pass the parameter as a reference, we don't pass the value of the parameter, but we pass the address of the parameter.
            
        *) Difference between Out and Ref:
            -> Out and ref work in the same way, but the small difference is:
            -> We don't initialized the out parameter, and out tell the compiler that the object will be initialized inside the method.
                -> Out can used to pass the argument as a reference and it is used to return the value from the function
            -> But in case of Ref, we need to initialized the ref parameter before passing into the method, and it tells the compiler that the object is already initialized before entering the function.
                -> Ref can used to pass the argument as a reference and it is used to modify the value of the argument
    */
    class Example
    {
        public void Method2(ref int x) // here we are taking x as reference, it means x contain the address of the variable num
        {
            x = 20; // here we are modifying the value of the address which is being pointed by x as well as num to the same memory location
        }
        public void Method1(out int x)
        {
            x = 10;
        }
    }
    class Prog
    {
        static public void Run(string[] args)
        {
            Example obj = new Example();
            int num = 0;
            obj.Method2(ref num); // here we are passing the passing num as reference
            Console.WriteLine(num);

            int num2;
            obj.Method1(out num2);
            Console.WriteLine(num2);
        }
    }
}