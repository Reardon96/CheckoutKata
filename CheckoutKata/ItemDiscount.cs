using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class ItemDiscount
    {
        public string Sku { get; set; }
        public int DiscountQuantity { get; set; }
        public float Discount { get; set; }

        public ItemDiscount(string sku, int discountQuantity, float discount)
        {
            Sku = sku;
            DiscountQuantity = discountQuantity;
            Discount = discount;
        }
    }
}
