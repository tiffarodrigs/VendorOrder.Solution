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
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor),newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string vName = "Test Vendor";
      Vendor newVendor = new Vendor(vName);
      string result = newVendor.VName;
      Assert.AreEqual(vName,result);
    }
  }
}