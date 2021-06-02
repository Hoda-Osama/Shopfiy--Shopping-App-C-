using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Fashion:Product 
    {
        string designer;
        private static List<Fashion> p = new List<Fashion>();
        public static List<Fashion> P
        {
            get { return p; }
        }
        public Fashion() { }
        public Fashion(int pid, string tittle, string description, int price, int instock,string designer):base(pid,tittle,description,price,instock)
         {
            this.designer = designer;
        }
        public string Designer
        {
            get { return designer; }
            set { designer = value; }
        }
        public static void initialize(List<Fashion> fashion)
        {


            Fashion f1 = new Fashion(1, "Shirt", "Three Quarter Sleeves Shirt White Model Number: I5280AZ", 2005, 54, "DeFacto");
            Fashion f2 = new Fashion(2, "Pants", "Cropped Cargo Pants Black Model Number: M9098AZ", 2005, 54, "DeFacto");
            Fashion f3 = new Fashion(1, "Watch", "Women's Women's Petite Melrose Water Resistant Stainless Steel Analog Watch DW00100217", 2005, 54, "DANIEL WELLINGTON");
            fashion.Add(f1);
            fashion.Add(f2);
            fashion.Add(f3);

        }
        public static void editstock(List<Fashion> fashion, int t)
        {
            foreach (var x in fashion)
            {
                if (x.Pid==t)
                {
                    x.Instocks -= 1;
                }
            }



        }
        public static Fashion searchitem(List<Fashion> fashion, string t)
        {
            Fashion b = new Fashion();

            foreach (var x in fashion)
            {
                if (x.Tittle.Contains(t) == true)
                {
                    b = x;
                    break;
                }

            }

            return b;
        }
        public static Fashion search(List<Fashion> fashion, int id)
        {
            return fashion.Find(y => y.Pid == id);
        }
        public static bool bsearch(List<Fashion> fashion,int id)
        {
            bool y = false;
            foreach (var x in fashion)
            {
                if (x.Pid==id)
                    y = true;
            }

            return y;
        }
        public override string ToString()
        {
            return "Book Id: " + Pid + "\n" + "Tittle: " + Tittle + "\n" + "Author: " + Description + "\n" + "\n" + "Year Of Bublication: " + Price + "\n" + "instock" + Instocks + "\n" + " Designer: " + Designer;
        }


    }
}
