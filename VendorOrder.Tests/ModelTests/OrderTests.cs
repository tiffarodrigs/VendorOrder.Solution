using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("name","desc",20);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrName_ReturnsOrderName_String()
    {
      string orName = "Cake";
      Order newOrder = new Order(orName,"desc",20);
      string result = newOrder.OrName;
      Assert.AreEqual(orName, result);
    }
    public void SetOrName_ReturnsOrderName_String()
    {
      string orName = "Cake";
      Order newOrder = new Order(orName,"desc",20);
      string updateName = "Pastry";
      newOrder.OrName=updateName;
      string result = newOrder.OrName;
      Assert.AreEqual(updateName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}