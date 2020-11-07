using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CheckoutKata
{
    static public class Discount
    {
        static public double CalculateDiscount (List<Item> basketItems, List<ItemDiscount> itemDiscounts)
        {
            double OverallDiscount = 0;
            foreach(ItemDiscount discount in itemDiscounts)
            {
                double discountBasketItemCount = basketItems.Count(e => e.Sku == discount.Sku);
                if (discountBasketItemCount >= discount.DiscountQuantity)
                {
                    OverallDiscount += Math.Floor(discountBasketItemCount / discount.DiscountQuantity) * discount.Discount;
                }
            }
            return OverallDiscount;
        }
    }
}

