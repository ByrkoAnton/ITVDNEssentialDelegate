using System;
using System.Security.Cryptography.X509Certificates;

namespace delegate02
{
    class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            double a, b;
            char action;

            Console.Write("enter operand A ");
            a = double.Parse(Console.ReadLine());

            Console.Write("enter acton");

            action = char.Parse(Console.ReadLine());

            Console.Write("enter operand B ");
            b = double.Parse(Console.ReadLine());

            Operation operation = null;
            if (action =='+')
                operation = (x, y) =>
                {
                    return x + y;
                };
            else if (action == '-') 
                operation = (x, y) =>
                {
                    return x - y;
                };
            else if (action =='*')
                operation = (x, y) =>
                {
                    return x * y;
                };
            else if (action == '/')
                operation = (x, y) =>
                {
                    if (y == 0)
                    {
                        Console.WriteLine("Zero division error");
                        return 0;
                    }
                    return x / y;
                };

            Console.WriteLine(operation != null ? $"{a} {action} {b} = {operation(a, b)}" : "operand is not correct");
        }
    }
}
