using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel;
using Model;
namespace Orders
{
    public class populateList
    {
        kahreedoEntities db = new kahreedoEntities();
        public List<Model.Order> orders()
        {
            List<Model.Order> list = new List<Model.Order>();
            var order = db.Orders.OrderByDescending(x => x.OrderID).ToList();
            foreach (var item in order)
            {
                Model.Order ord = new Model.Order();
                ord.OrderID = Convert.ToString(item.OrderID);
                ord.CustomerID = Convert.ToString(item.CustomerID);
                ord.PaymentID = Convert.ToString(item.PaymentID);
                ord.ShippingID = Convert.ToString(item.ShippingID);
                ord.Discount = Convert.ToString(item.Discount);
                ord.Taxes = Convert.ToString(item.Taxes);
                ord.TotalAmount = Convert.ToString(item.TotalAmount);
                ord.isCompleted = Convert.ToString(item.isCompleted);
                ord.OrderDate = Convert.ToString(item.OrderDate);
                ord.DIspatched = Convert.ToString(item.DIspatched);
                ord.DispatchedDate = Convert.ToString(item.DispatchedDate);
                ord.Shipped = Convert.ToString(item.Shipped);
                ord.ShippingDate = Convert.ToString(item.ShippingDate);
                ord.Deliver = Convert.ToString(item.Deliver);
                ord.DeliveryDate = Convert.ToString(item.DeliveryDate);
                ord.Notes = Convert.ToString(item.Notes);
                ord.CancelOrder = Convert.ToString(item.CancelOrder);
                list.Add(ord);
            }
            return list;
        }

        public List<Model.OrderDetails> ordersDetails(int id)
        {
            List<Model.OrderDetails> list = new List<Model.OrderDetails>();
            var order = db.OrderDetails.Where(x => x.OrderID == id).ToList();
            foreach (var item in order)
            {
                Model.OrderDetails ord = new Model.OrderDetails();
                ord.OrderID = Convert.ToString(item.OrderID);
                ord.OrderDetailsID = Convert.ToString(item.OrderDetailsID);
                ord.ProductID = Convert.ToString(item.ProductID);
                ord.UnitPrice = Convert.ToString(item.UnitPrice);
                ord.Discount = Convert.ToString(item.Discount);
                ord.Quantity = Convert.ToString(item.Quantity);
                ord.TotalAmount = Convert.ToString(item.TotalAmount);
                ord.OrderDate = Convert.ToString(item.OrderDate);
                list.Add(ord);
            }
            return list;
        }
    }
}
