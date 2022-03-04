using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {

    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("name");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrName_ReturnsOrderName_String()
    {
      string orName = "Cake";
      Order newOrder = new Order(orName);
      string result = newOrder.OrName;
      Assert.AreEqual(orName, result);
    }
    public void SetOrName_ReturnsOrderName_String()
    {
      string orName = "Cake";
      Order newOrder = new Order(orName);
      string updateName = "Pastry";
      newOrder.OrName=updateName;
      string result = newOrder.OrName;
      Assert.AreEqual(updateName, result);
    }
  }
}