using System;

namespace Calculator
{
    class FirstProject
    {
        static void Main(string[] args)
        {
            char op;
            double first, second,result;
            Console.WriteLine("First Value");
            first=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Value");
            second=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operators (+, -, *, /): ");
            op = (char)Console.Read();
            
            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;
                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}",first,second,result);
                    break;
                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}",first,second,result);
                    break;
                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}