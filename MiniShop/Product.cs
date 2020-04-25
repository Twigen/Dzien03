using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private double price;
        private string name;
        private string descript=string.Empty;
        private bool promo = false;
        private bool isAvailible = true;
        private UInt16 version=0;

        public double Price { get { return price; }  }

        public void SetParam(int id, double price, string name, string descript)
        {

        }
        public void ChangePrice(double newprice)
        {
            //logowanie historii zmian ceny
        }
        public void ChangeDesc(string newDescription)
        {

        }
        public void SetActive(bool avail)
        {
            this.isAvailible = avail;

        }
        
    }
}
