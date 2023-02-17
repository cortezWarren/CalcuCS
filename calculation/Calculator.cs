using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcCs.retry;

namespace calcCs.calculation
{
    class Calculator
    {
        public void runCalc()
        {
            int num1;
            int num2;
            Retry retry = new Retry();

            Console.WriteLine("Enter first number");
            num1 = getCalc();

            Console.WriteLine("Enter second number");
            num2 = getCalc();

            retry.Reload();
        }

        private int getCalc()
        {
            int val;
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out val);

            while (!parseCheck)
            {
                Console.WriteLine("Enter numbers only");
                parseCheck = Int32.TryParse(Console.ReadLine(), out val);

            }
            return val;
        }
    }
}
