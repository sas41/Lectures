using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid product name!");
                }
                name = value;
            }
        }

        public double Price
        {
            get
            {
                if (IsOnPromotion)
                {
                    return price * 0.8;
                }
                return price;
            }
            private set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value;
            }
        }

        public bool IsOnPromotion { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            IsOnPromotion = false;
        }

        public Product(string name, double price, bool isOnPromotion)
        {
            Name = name;
            Price = price;
            IsOnPromotion = isOnPromotion;
        }

        public override string ToString()
        {
            string promo = "NO";
            if (IsOnPromotion)
            {
                promo = "YES";
            }
            return $"Product -> {Name} with price {string.Format("{0:F2}", Price)}. On promotion {promo}"; 
        }
    }
}
