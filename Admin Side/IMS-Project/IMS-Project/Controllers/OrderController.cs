using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS_Project.Models;
using DBModel;
using Model;
using Orders;
namespace IMS_Project.Controllers
{
    public class OrderController : Controller
    {
        kahreedoEntities db = new kahreedoEntities();
        // GET: Order
        public ActionResult Index()
        {
            populateList pList = new populateList();
            return View(pList.orders());
        }
        public ActionResult Details(int id)
        {
            String ids = Convert.ToString(id);
            populateList pList = new populateList();
            var OrderList = pList.orders();
            OrderList = OrderList.Where(x => x.OrderID == ids).ToList();
            var OrderDetailList = pList.ordersDetails(id).ToList();
            DBModel.Order ord = db.Orders.Find(id);
            var Ord_details = db.OrderDetails.Where(x => x.OrderID == id).ToList();
            var tuple = new Tuple<IEnumerable<Model.Order>, IEnumerable<Model.OrderDetails>>(OrderList, OrderDetailList);

            double SumAmount = Convert.ToDouble(Ord_details.Sum(x => x.TotalAmount));
            ViewBag.TotalItems = Ord_details.Sum(x => x.Quantity);
            ViewBag.Discount = 0;
            ViewBag.TAmount = SumAmount - 0;
            ViewBag.Amount = SumAmount;
            return View(tuple);
        }
    }
}