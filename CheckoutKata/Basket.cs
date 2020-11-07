using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CheckoutKata
{
    public class Basket
    {
        public List<Item> ScannedItems = new List<Item>();

        public void ScanItem(Item item)
        {
            ScannedItems.Add(item);
        }

        public void ScanAllItems(List<Item> items)
        {
            foreach (Item item in items)
            {
                ScanItem(item);
            }
        }

        public double GetTotalPrice(List<Item> basketItems, List<ItemDiscount> itemDiscounts)
        {
            double totalBeforeDiscount = basketItems.Sum(e => e.UnitPrice);
            double basketDiscount = Discount.CalculateDiscount(basketItems, itemDiscounts);

            return totalBeforeDiscount - basketDiscount;
        }
    }
}
