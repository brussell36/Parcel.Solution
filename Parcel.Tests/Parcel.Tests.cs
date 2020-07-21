using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Shipping.Models;
using System;

namespace Shipping.Tests
{
  [TestClass]
  public class TestParcel
  {
  [TestMethod]
    public void Parcel_CalculateParcelOrderPrice_ParcelPrice()
    {
      Parcel parcelOrder = new Parcel(12, 12, 12, 6);
      parcelOrder.Volume();
      Assert.AreEqual(34, parcelOrder.ShippingCalc());
    }    
  }
}
