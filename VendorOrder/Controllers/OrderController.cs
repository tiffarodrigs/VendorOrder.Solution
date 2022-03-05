using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
      
    }
    [HttpGet("vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId,int orderId)
    {
      Order selectedOrder = Order.Find(orderId);
      Vendor Ordersvendor = Vendor.Find(vendorId);
      Dictionary<string,object> model = new Dictionary<string,object>();
      model.Add("vendor",Ordersvendor);
      model.Add("order",selectedOrder);
      return View(model);
      
    }
    //     [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }
  }
}  