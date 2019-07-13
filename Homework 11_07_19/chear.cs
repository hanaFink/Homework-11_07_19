using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_19
{
    class Chear : Product
    {
        protected string _color;

        public Chear(int priceWithoutVat, string supplName, int quentety, string color, string productName) :
            base(priceWithoutVat, supplName, quentety, "Chear")
        {
            _color = color;
        }
        public override void ShowProduct()
        {
            Console.WriteLine("*        ");
            Console.WriteLine("*        ");
            Console.WriteLine("*        ");
            Console.WriteLine("*********");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");

        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Color of Chear is :" + _color);
        }

    }
}

