using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Store
    {
        public string name { get; set; }
        public List<Vendor> vendors { get; set; }
        public List<Item> items { get; set; }

        public Store() 
        {
            vendors = new List<Vendor>();
            items = new List<Item>();
        }
    }
}
