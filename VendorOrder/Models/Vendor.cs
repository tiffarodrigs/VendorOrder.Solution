using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Vendor
  {
    // properties, constructors, methods, etc. go here
  public string VName {get;set;}
  public string VDesc {get;set;}
  public int Id { get; set; }
  private static List<Vendor>  _vInstance = new List<Vendor> {};

  public List<Order> VenOrdObjList {get; set;}
  public Vendor(string vName,string vDesc)
  {
    VName = vName;
    VDesc = vDesc;
    _vInstance.Add(this);
    Id = _vInstance.Count;
    VenOrdObjList = new List<Order>{};
  }
  public static void ClearAll()
  {
    _vInstance.Clear();
  }
    public static void ClearOne(int id)
  {
    _vInstance.RemoveAt(id-1);
    foreach (Vendor vendor in  _vInstance)
    {
      if(vendor.Id > id)
      {
        vendor.Id = vendor.Id-1;
      }     
    }
  }
  public static List<Vendor> GetAll()
  {
    return _vInstance;
  }
  public static  Vendor Find(int searchId)
  {
    return _vInstance[searchId-1];
  }
  public void AddOrder (Order order)
  {
    VenOrdObjList.Add(order);
  }
  public void RemoveOrder (int orderId)
  {
    VenOrdObjList.RemoveAt(orderId-1);
    foreach (Order order in  VenOrdObjList)
    {
      if(order.Id > orderId)
      {
        order.Id = order.Id-1;
      }     
    }
  }
  
  }
}