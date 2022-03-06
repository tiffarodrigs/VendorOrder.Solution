using System;
using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Order
  {
    public string OrName{get; set;}
    public string OrDesc{get; set;}
    public int  OrPrice{get; set;}
    public int Id{get; set;}
    public string OrDate {get; set;}
    // DateTime curDate = DateTime.Now
    // public string OrDate =curDate.ToString("MM/dd/yyyy")
    private static List<Order> _orInstance =new List<Order>{};
    public Order(string orName,string orDesc, int orPrice,string orDate)
    {
      OrName = orName;
      OrDesc = orDesc;
      OrPrice = orPrice;
      OrDate = orDate;
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

  public static void ClearOne(int id)
  {
    _orInstance.RemoveAt(id-1);
    Console.WriteLine("_orInstance.Count"+_orInstance.Count);
    foreach(Order order in _orInstance)
    {
      if(order.Id > id)
      {
        order.Id = order.Id -1;
      }
    }
  }  
  public static Order Find(int searchId)
    {
      
      return _orInstance[searchId-1];
    }    

      
  }
}