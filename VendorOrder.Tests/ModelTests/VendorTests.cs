using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string desc = "Test Vendor Desc";
      Vendor newVendor = new Vendor(name,desc);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

     [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Cafe1";
      string desc01 = "Desc1";
      string name02 = "Cafe2";
      string desc02 = "Desc1";
      Vendor newVendor1 = new Vendor(name01,desc01);
      Vendor newVendor2 = new Vendor(name02,desc02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}