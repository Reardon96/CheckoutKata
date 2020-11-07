using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    class Checkout
    {
        static void Main(string[] args)
        {
            Basket currentBasket = new Basket();
            List<ItemDiscount> itemDiscounts = new List<ItemDiscount>();
            List<Item> unscannedItems = new List<Item>();

            currentBasket.ScanAllItems(unscannedItems);

            Console.WriteLine(currentBasket.GetTotalPrice(currentBasket.ScannedItems, itemDiscounts));
        }
    }
}

