
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_07_19
{
    class Program
    {

        static void Main()
        {
            Chear c1 = new Chear(20, "aaa", 5, "green", "sds");
        


            Table t1 = new Table(100, "bbb", 8, "t", 6);
        

            Closet cl1 = new Closet(1000, "ccc", 50, "z", 100);
           
            Product [] p  = new Product [ 3 ];
            p[0] = c1;
            p[1] = t1;
            p[2] = cl1;
            for (int i = 0; i < p.Length; i++)
            {
                p[i].ShowDetails();
                p[i].ShowProduct();
                p[i].CalcInventoryPrice();

            }



        }
    }
}