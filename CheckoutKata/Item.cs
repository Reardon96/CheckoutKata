using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class Item
    {
        public double UnitPrice { get; set; }
        public string Sku { get; set; }

        public Item(string sku, double unitPrice)
        {
            UnitPrice = unitPrice;
            Sku = sku;
        }
    }
}
