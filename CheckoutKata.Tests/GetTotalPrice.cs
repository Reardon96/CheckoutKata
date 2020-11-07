using CheckoutKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace CheckoutKata.Tests
{
    public class GetTotalPrice
    {
        [SetUp]
        public void Setup()
        {
        }

        List<Item> UnscannedItems = new List<Item>()
            {
                new Item("A", 50),
                new Item("A", 50),
                new Item("A", 50),
                new Item("A", 50),
                new Item("B", 30),
                new Item("B", 30),
                new Item("B", 30),
                new Item("C", 20),
                new Item("C", 20),
                new Item("D", 70),
            };

        [Test]
        public void OneItemDiscount()
        {
            // Prepare
            Basket currentBasket = new Basket();
            List<ItemDiscount> itemDiscounts = new List<ItemDiscount>()
            {
                new ItemDiscount("A", 3, 15),
            };
            currentBasket.ScanAllItems(UnscannedItems);

            // Actual
            var actual = currentBasket.GetTotalPrice(currentBasket.ScannedItems, itemDiscounts);

            // Expected
            var expected = 385;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}