using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test1","test2");
      Assert.AreEqual(typeof(Vendor),newVendor.GetType());
    }

    [TestMethod]
    public void GetVName_ReturnName_String()
    {
      string vName = "Test Vendor";
      Vendor newVendor = new Vendor(vName,"test2");
      string result = newVendor.VName;
      Assert.AreEqual(vName,result);
    }

    [TestMethod]
    public void GetVDesc_ReturnDescription_String()
    {
      string desc = "Test Vendor Desc";
      Vendor newVendor = new Vendor("test1",desc);
      string result = newVendor.VDesc;
      Assert.AreEqual(desc,result);
    }
  }
}