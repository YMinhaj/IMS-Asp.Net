using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetails
    {
        public String OrderDetailsID { get; set; }
        public String OrderID { get; set; }

        public String ProductID { get; set; }
        public String UnitPrice { get; set; }
        public String Quantity { get; set; }
        public String Discount { get; set; }
        public String TotalAmount { get; set; }
        public String OrderDate { get; set; }
       
    }
}
