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
        public double price { get; set; }
        public bool sold { get; set; }
        public string paymentDistributed { get; set; }
        public Vendor owner { get; set; }

        public string DisplayItm 
        {
            get
            {
            return string.Format("{0}-${1}", title, price);

            }
                
        }

    }
}
