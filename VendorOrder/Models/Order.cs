using System;
using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Order
  {
    public string OrName{get; set;}
    //public string OrDesc{get; set;}
   // public int  OrPrice{get; set;}
    // DateTime curDate = DateTime.Now
    // public string OrDate =curDate.ToString("MM/dd/yyyy")
    public Order(string orName)
    {
      OrName = orName;
    }
    //     public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}