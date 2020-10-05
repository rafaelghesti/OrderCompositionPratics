using System;
using System.Collections.Generic;
using System.Globalization;

namespace OrderCompositionPratics.Entities
{
    class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantify, double price, Product product)
        {
            Quantify = quantify;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantify;
        }

        public override string ToString()
        {
            return "Product: "+Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantify: "
                + Quantify
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
