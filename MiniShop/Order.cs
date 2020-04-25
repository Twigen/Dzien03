using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Order
    {
        private string orderNumber;
        private List<OrderItem> listProd = new List<OrderItem>();
        private byte discount = 0;
        private string costumerName;
        private string shipAddress;
        
        private DateTime orderDate;
        private OrderStatus status;
        public double totalAmount {
            get { return CalcTotalAmount(); } } 
        private enum OrderStatus
        {
            NewOrder,
            Compleate,
            Shipped,
            Returned,
            Confirmed,
            Cancelled
        }
        public bool AddProduct(Product product, int quantity)
        {
            //akcja dodania produktu do listy sprawdzic status
            if (status == OrderStatus.NewOrder && quantity >= 0 && product != null)
            {
                listProd.Add(new OrderItem(product, quantity));
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Clear()
        {

            if (status == OrderStatus.NewOrder)
            {
                listProd.Clear();
                return true;
            }
            else
                return false;
        }
        private double CalcTotalAmount()
        {
            double amount = 0.0;
            foreach (var item in listProd)
            {
                amount += item.ProductPrice * item.Quantity;
            }
            if(discount >= 0 && discount <=100)
            amount *= (100-discount)/100.0;
            return amount;
        }
        public void Print()
        {
            foreach (var item in listProd)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}","");
            }
        }
    }
}
