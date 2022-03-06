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
      Dictionary<string,object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.VenOrdObjList;
      model.Add("vendor",selectedVendor);
      model.Add("orders",vendorOrders);
      return View(model);
    }
        // This one creates new oders within a given vendors, not new vendors:
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string orderDescription,int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName,orderDescription, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.VenOrdObjList;
      model.Add("orders", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpPost("/vendors/{vendorId}/delete")]
    public ActionResult Delete(int vendorId)
    {
      Vendor.ClearOne(vendorId);
      //return RedirectToAction("Show");
      return RedirectToAction("Index");
    }

    //Return the Show.cshtml in Vendor after deleting selected Order
    [HttpPost("vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult DeleteOne(int vendorId,int orderId)
    {
      Console.WriteLine("jjj"+orderId);
      Dictionary <string,object> model1 = new Dictionary<string,object> ();
      Vendor foundedVendor = Vendor.Find(vendorId);
      List<Order> vendorsCurrentOrders = foundedVendor.VenOrdObjList;
      Console.WriteLine("vendorsCurrentOrders.Count" +vendorsCurrentOrders.Count);
      foreach(Order order in vendorsCurrentOrders)
      {
        if(order.Id==orderId)
        {
        Console.WriteLine(" id of order insed vendor" + order.Id);
        vendorsCurrentOrders.Remove(order);
        Order.GetAll().Remove(order);
        break;     
        }

        Console.WriteLine("vendorsCurrentOrders.Count" +vendorsCurrentOrders.Count);
      }
      foreach(Order order in vendorsCurrentOrders)
      {
        if(order.Id > orderId)
        {
        order.Id = order.Id-1;
        }
      }
      foreach(Order order in Order.GetAll())
      {
        if(order.Id > orderId)
        {
        order.Id = order.Id-1;
        }
      }
      Console.WriteLine("Order class list count" +Order.GetAll().Count);

      model1.Add("vendor",foundedVendor);
      model1.Add("orders",vendorsCurrentOrders);
      Console.WriteLine("vendorsCurrentOrders.Count1" +vendorsCurrentOrders.Count);
      Console.WriteLine("Order class list count1" +Order.GetAll().Count);

        return View("Show", model1);
    }

  }
} 