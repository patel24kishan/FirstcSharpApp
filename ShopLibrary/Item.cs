using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Item
    {
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string sold { get; set; }
        public string paymentDistributed { get; set; }
        public Vendor owner { get; set; }

    }
}
