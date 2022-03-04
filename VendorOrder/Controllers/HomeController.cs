using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;
namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  [Route("/favorite_photos")]
  public ActionResult FavoritePhotos()
  {
    return View();
  }
  }
}