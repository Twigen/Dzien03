using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        private Product product;
        private int quantity;

        public double ProductPrice { get
            {
                return product.Price;
            } }
        public int Quantity { get {return quantity }  }
        public OrderItem(Product product, int quantity)
        {

        }

    }
}
