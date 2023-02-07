using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Vendor
    {
        public int vendorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double comission { get; set; }
        public double payment { get; set; }

        public string DisplayVendor
        {
            get
            {
                return string.Format("{0} {1}, ${2}", firstName, lastName,payment);

            }

        }
        public Vendor()
        {
            comission = 0.5;
        }
    }
}
