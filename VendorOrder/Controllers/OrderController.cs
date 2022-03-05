using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/order/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}  