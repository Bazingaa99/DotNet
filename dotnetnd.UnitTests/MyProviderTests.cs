using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyLibrary;
using System;

namespace dotnetnd.UnitTests
{
    [TestClass]
    public class MyProviderTests
    {
        [TestMethod]
        public void FindStore_ExistingID_ReturnCorrectStore()
        {
            MyProvider provider = new MyProvider();
            provider.stores = new List<Store>() { new Store { id = 1, isActive = true, name = "Steam" },
                                                  new Store { id = 2, isActive = true, name = "GOG" },
                                                  new Store { id = 3, isActive = true, name = "Origin" } };

            var result = provider.FindStore(2);

            Assert.AreEqual("GOG", result.name);
        }

        [TestMethod]
        public void FindStore_NonExistingID_ReturnDefaultStore()
        {
            MyProvider provider = new MyProvider();
            provider.stores = new List<Store>() { new Store { id = 1, isActive = true, name = "Steam" },
                                                  new Store { id = 2, isActive = true, name = "GOG" },
                                                  new Store { id = 3, isActive = true, name = "Origin" } };

            var result = provider.FindStore(4);

            Assert.AreEqual("Store not found", result.name);
        }

        [TestMethod]
        public void GetTotalPrice_PopulatedListSalePrice_ReturnTotalSalePrice()
        {
            List<Deal> deals = new List<Deal>() { new Deal { salePrice = 10 },
                                                  new Deal { salePrice = 10 },
                                                  new Deal { salePrice = 10 } };

            MyProvider provider = new MyProvider();

            var totalSalePrice = 30;

            var result = provider.GetTotalPrice(deals, "salePrice");

            Assert.AreEqual(result, totalSalePrice);
        }

        [TestMethod]
        public void GetTotalPrice_PopulatedListNormalPrice_ReturnTotalNormalPrice()
        {
            List<Deal> deals = new List<Deal>() { new Deal { normalPrice = 10 },
                                                  new Deal { normalPrice = 10 },
                                                  new Deal { normalPrice = 10 } };

            MyProvider provider = new MyProvider();

            var totalNormalPrice = 30;

            var result = provider.GetTotalPrice(deals, "normalPrice");

            Assert.AreEqual(result, totalNormalPrice);
        }

        [TestMethod]
        public void GetTotalPrice_EmptyList_ReturnSumOfZero()
        {
            List<Deal> deals = new List<Deal>();

            MyProvider provider = new MyProvider();

            var result = provider.GetTotalPrice(deals, "normalPrice");

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void GetTotalPrice_PopulatedlistNonFloatProperty_ReturnSumOfZero()
        {
            List<Deal> deals = new List<Deal>() { new Deal { id = "1" },
                                                  new Deal { id = "2" },
                                                  new Deal { id = "3" } };

            MyProvider provider = new MyProvider();

            var result = provider.GetTotalPrice(deals, "id");

            Assert.AreEqual(result, 0);
        }
    }
}
