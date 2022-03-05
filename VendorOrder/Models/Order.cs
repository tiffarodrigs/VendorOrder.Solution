using System;
using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Order
  {
    public string OrName{get; set;}
    public string OrDesc{get; set;}
    public int  OrPrice{get; set;}
    public int Id{get;}
    // DateTime curDate = DateTime.Now
    // public string OrDate =curDate.ToString("MM/dd/yyyy")
    private static List<Order> _orInstance =new List<Order>{};
    public Order(string orName,string orDesc, int orPrice)
    {
      OrName = orName;
      OrDesc = orDesc;
      OrPrice = orPrice;
      _orInstance.Add(this);
      Id = _orInstance.Count;


    }

    public static List<Order> GetAll()
    {
      return _orInstance;
    }

  public static void ClearAll()
    {
      
      _orInstance.Clear();
    }
  public static Order Find(int searchId)
    {
      
      return _orInstance[searchId-1];
    }    

      
  }
}