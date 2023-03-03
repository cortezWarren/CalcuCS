using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using calcCs.retry;

namespace calcCs.calculation
{
    public enum OperatorSign
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4
     }
    class Calculator
    {
        public void runCalc()
        {
            double num1;
            double num2;
            double ans;
            string operation;

            Retry retry = new Retry();

            Console.WriteLine("Enter first number");
            num1 = getCalc();

            operation = getType();

            Console.WriteLine("Enter second number");
            num2 = getCalc();

            ans = answer(num1, num2, operation);

            retry.Reload();
        }

        private double getCalc()
        {
            double val;
            bool parseCheck = Double.TryParse(Console.ReadLine(), out val);

            while (!parseCheck)
            {
                Console.WriteLine("Enter numbers only");
                parseCheck = Double.TryParse(Console.ReadLine(), out val);

            }
            return val;
        }

        private string getType()
        {
            var opOne = OperatorSign.Add;
            var opTwo = OperatorSign.Subtract;
            var opThree = OperatorSign.Multiply;
            var opFour = OperatorSign.Divide;
             // Console.WriteLine((int)opThree);
            int plus = (int)opOne;
            int minus = (int)opTwo;
            int multi = (int)opThree;
            int divide = (int)opFour;


            string[] type = new string[8] 
            { 
                "+", "-", "*", "/",
                plus.ToString(), minus.ToString(), multi.ToString(), divide.ToString(),
            };
            Console.WriteLine("Enter valid operator:");
            Console.WriteLine("1 : {0}",opOne);
            Console.WriteLine("2 : {0}",opTwo);
            Console.WriteLine("3 : {0}",opThree);
            Console.WriteLine("4 : {0}",opFour);


            string typeCheck = Console.ReadLine();
            string isNum = typeCheck;

            while (!type.Contains(typeCheck))
            {
                Console.WriteLine("Invalid operator");
                typeCheck = Console.ReadLine();
            }

            if (typeCheck == plus.ToString() || typeCheck == type[0])
            {
                isNum = opOne.ToString();

            }
            else if (typeCheck == minus.ToString() || typeCheck == type[1])
            {
                isNum = opTwo.ToString();

            }
            else if (typeCheck == multi.ToString() || typeCheck == type[2])
            {
                isNum = opThree.ToString();

            }
            else if (typeCheck == divide.ToString() || typeCheck == type[3])
            {
                isNum = opFour.ToString();
            }


            Console.WriteLine("operator: {0}",isNum);
            return typeCheck;
        }

        private double answer(double num1, double num2, string type)
        {
            double final;
            double val1 = num1;
            double val2 = num2;

            final = 0.0;
            switch (type)
            {
                case "+":
                case "1":
                    final = val1 + val2;
                    break;
                case "-":
                case "2":
                    final = val1 - val2;
                    break;
                case "*":
                case "3":
                    final = val1 * val2;
                    break;
                case "/":
                case "4":
                    final = val1 / val2;
                    break;
                default:
                    Console.WriteLine("Syntax Error");
                    break;
            };

            Console.WriteLine("The answer is " + final);
            return final;

        }
    }
}
