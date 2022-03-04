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
  }
} 