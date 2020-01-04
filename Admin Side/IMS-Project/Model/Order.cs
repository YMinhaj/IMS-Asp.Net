using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {

        public String OrderID { get; set; }
        public String CustomerID { get; set; }
        public String PaymentID { get; set; }
        public String ShippingID { get; set; }

        public String Discount { get; set; }
        public String Taxes { get; set; }
        public String TotalAmount { get; set; }
        public String isCompleted { get; set; }
        public String OrderDate { get; set; }
        public String DIspatched { get; set; }

        public String DispatchedDate { get; set; }
        public String Shipped { get; set; }

        public String ShippingDate { get; set; }
        public String Deliver { get; set; }
        public String DeliveryDate { get; set; }

        public String Notes { get; set; }
        public String CancelOrder { get; set; }


    }
}
