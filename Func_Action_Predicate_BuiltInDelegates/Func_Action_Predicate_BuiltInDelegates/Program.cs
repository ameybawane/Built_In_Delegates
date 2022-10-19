using System;

namespace Func_Action_Predicate_BuiltInDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * It takes one or more input parameters and returns one out parameter. 
             * The last parameter is considered as a return value.
             * Func delegate type can include 0 to 16 input parameters of different types. 
             * It must have one return type. 
             * So return type is mandatory but input parameter is not.
            */
            Func<int, float, double, double> obj1 = (x, y, z) => x + y + z;
            double result = obj1.Invoke(100, 34.4f, 145.45);
            Console.WriteLine("Func Delegate: " + result);

            /*
             * It takes one or more input parameters and returns nothing.
             * So it does not return any value.
            */
            Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z);
            Console.Write("Action Delegate: ");
            obj2.Invoke(100, 34.4f, 145.45);

            /*
             * It is used to verify certain criteria of method and 
             * returns output as Boolean, either True or False.
             * Predicate can be used with method, anonymous and lambda expression.
            */
            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("Hello World!");
            Console.WriteLine("Predicate Delegate: " + status);

            Console.ReadKey();
        }
    }
}
