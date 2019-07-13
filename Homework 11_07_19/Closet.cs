using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_19
{
    class Closet:Product
    {

        protected int _hight;

        public Closet(int priceWithoutVat, string supplName, int quentety, string productName, int hight) :
            base(priceWithoutVat, supplName, quentety, "Table")
        {
            _hight = hight;
        }
        public override void ShowProduct()
        {
            Console.WriteLine("****************");
            Console.WriteLine("*******  *******");
            Console.WriteLine("*******  *******");
            Console.WriteLine("*******  *******");
            Console.WriteLine("*******  *******");
            Console.WriteLine("*******  *******");
            Console.WriteLine("****************");

        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("The hight of closet is :" + _hight);
        }

    }
}

