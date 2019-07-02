using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Order
    {
        public static int OrdersCount { get; private set; }
        public int OrderNumber { get; private set; }
        public List<Product> ProductsList { get; private set; }

        public Order(int orderNumber, List<Product> productsList)
        {
            OrderNumber = orderNumber;
            ProductsList = productsList;
            OrdersCount++;
        }

        public void AddProduct(Product toAdd)
        {
            ProductsList.Add(toAdd);
        }

        public int GetDiscountedProductsCount()
        {
            return ProductsList.Where(x => x.IsOnPromotion).Count();
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return ProductsList.Where(x => x.IsOnPromotion).Select(x => x.Price).Sum();
        }

        public double GetOrderTotalPrice()
        {
            return ProductsList.Select(x => x.Price).Sum();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Order #333333 has the following products:");
            foreach (var product in ProductsList)
            {
                sb.Append(Environment.NewLine);
                sb.Append("### ");
                sb.Append(product.ToString());
            }
            return sb.ToString();
        }
    }
}
