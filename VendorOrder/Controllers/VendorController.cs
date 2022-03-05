using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName,string vendorDesc)
    {
      Vendor vendorObj = new Vendor(vendorName,vendorDesc);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorObjList = Vendor.GetAll();
      return View(vendorObjList);
    }
    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string,objet> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.VenOrdObjList
      model.Add("vendor",selectedVendor)
      model.Add("orders",vendorOrders)
      return View(model);
    }
        // This one creates new oders within a given vendors, not new vendors:
    [HttpPost("/vendors/{vendorId}/orders")]
       public ActionResult Create(int vendorId, string orderName, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName,orderDescription);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Order;
      model.Add("order", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
} 