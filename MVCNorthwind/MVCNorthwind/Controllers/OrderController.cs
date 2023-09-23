using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCNorthwind.Models;
using System.Collections.Generic;

namespace MVCNorthwind.Controllers
{
    public class OrderController : Controller
    {
        private readonly RepositoryOrder _order;

        public OrderController(RepositoryOrder orders)
        {
            _order = orders;
        }
        // GET: OrderController
        public ActionResult Index()
        { 
            List<int> orders = _order.GetAllOrderId();
            OrderIDViewModel orderId=new OrderIDViewModel(orders);
            return View(orderId);
        }

        // GET: OrderController/Details/5
        [HttpPost]
        public ActionResult Details(int id)
        {
            Order order=_order.FindOrderById(id);
            List<OrderDetail> orderList = _order.GetOrderDetails(id);
            ViewData["order"] = orderList;
            return View(order);
        }
        

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
