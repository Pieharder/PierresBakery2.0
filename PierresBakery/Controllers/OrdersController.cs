using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/order/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}