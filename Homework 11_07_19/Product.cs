using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_19
{
    abstract class Product
    {
        protected int _priceWithoutVat;
        private double _vat;
        protected string _productName;
        protected string _supplName;
        protected int _quentety;

        public Product(int priceWithoutVat, string supplName, int quentety, string productName)
        {
            _priceWithoutVat = priceWithoutVat;
            _vat = 0.17;
            _productName = productName;
            _supplName = supplName;
            _quentety = quentety;
        }

        public abstract void ShowProduct();

        public double CalcInventoryPrice()
        {
            Console.WriteLine("Price Of Item is " + (_priceWithoutVat * (1 + _vat)));
            Console.WriteLine();
            return _priceWithoutVat *(1+ _vat);

        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Product name is {0},\nPrice of the product is {1},\nSuppluer name is {2},\nQuentaty is {3}", _productName, _priceWithoutVat * _vat, _supplName, _quentety);
        }

    }
}


