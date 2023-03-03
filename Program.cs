using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using calcCs.calculation;
using calcCs.List;

namespace calcCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            ItemList list = new ItemList();
           // Console.WriteLine(list.Name);
           // Console.WriteLine(list.Listing());
            Console.ReadLine();
            // calculator.runCalc();

            /*for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            int num = 1;
            while (num <= 5)
            {
                Console.WriteLine($"line {num}");
                num++;

            }
            Console.ReadLine();*/
/*
            List<ItemList> lst = new List<ItemList>();

            lst.Add(new ItemList { Name = "Glasses", ItemId = 1 });
            lst.Add(new ItemList { Name = "Chair", ItemId = 2 });

            foreach (ItemList item in lst)
            {
                Console.WriteLine(item.Name.ToString() + " " + item.ItemId.ToString());

            }
            Console.ReadLine();*/
        }
    }
}
