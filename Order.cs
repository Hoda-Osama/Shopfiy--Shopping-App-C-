using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Order
    {
        private static List<Product> p = new List<Product>();
        public static List<Product> P
        {
            get { return p; }
        }
        public static void add(List<Product> P, Product x)
        {
           p.Add(x);
           
        }
        public static bool isempty(List<Product> P)
        {
            bool x =false;
            if(Order.count(p)==0)
            {
                x = true; 
            }
            return x;
        }
        public static int total(List<Product> P)
        {
            int sum = 0;
            foreach(var x in p)
            {
                sum += x.Price;
            }
            return sum;
        }
        public static int count(List<Product> P)
        {
            int c= 0;
            foreach (var x in p)
            {
                c += 1;
            }
            return c;
        }
        





    }
}
