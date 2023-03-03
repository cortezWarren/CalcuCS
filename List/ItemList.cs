using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCs.List
{
    public class ItemList
    {
        public string Name { get; set; }
        public int ItemId { get; set; }

        public ItemList() {
            Name = "Mouse";
            ItemId= 9;
        }

        public string Listing()
        {
            string type = "pc part";
            Console.WriteLine($"name: {Name} the type is {type}");
            return type;
        }
    }
}
