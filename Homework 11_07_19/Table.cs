using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_19
{
    class Table:Product
    {
        protected int _numOfLegs;

        public Table(int priceWithoutVat, string supplName, int quentety, string productName, int numOfLegs) : 
            base(priceWithoutVat, supplName, quentety, "Table")
        {
            _numOfLegs = numOfLegs;
        }
        public override void ShowProduct()
        {
            Console.WriteLine("****************");
            Console.WriteLine("*              *");
            Console.WriteLine("*              *");
            Console.WriteLine("*              *");
            Console.WriteLine("*              *");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Number of Legs is :" + _numOfLegs);
        }

    }
}
