using System.Collections.Generic;
namespace VendorOrder.Models
{
  public class Vendor
  {
    // properties, constructors, methods, etc. go here
  public string VName {get;set;}
  public string VDesc {get;set;}
  public int Id { get; }
  private static List<Vendor>  _vInstance = new List<Vendor> {};
  
  public Vendor(string vName,string vDesc)
  {
    VName = vName;
    VDesc = vDesc;
    _vInstance.Add(this);
    Id = _vInstance.Count;
  }
  public static void ClearAll()
  {
    _vInstance.Clear();
  }
  public static List<Vendor> GetAll()
  {
    return _vInstance;
  }
  public static  Vendor Find(int searchId)
  {
    return _vInstance[searchId-1];
  }
  
  }
}