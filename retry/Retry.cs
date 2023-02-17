using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcCs.calculation;

namespace calcCs.retry
{
    public class Retry
    {
        public string Reload()
        {
            Console.WriteLine("Type 'yes' to reload console");
            Calculator calculator = new Calculator();
            string reloadCons = Console.ReadLine().ToString();

            if (reloadCons == "yes")
            {
                calculator.runCalc();
            }
            else
            {
                System.Environment.Exit(0);
            }

            return reloadCons;
        }
    }
}
