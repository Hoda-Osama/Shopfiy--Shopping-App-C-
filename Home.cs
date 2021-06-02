using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Home:Product
    {
        string supplier;
        private static List<Home> p = new List<Home>();
        public static List<Home> P
        {
            get { return p; }
        }
        public Home() { }
        public Home(int pid, string tittle, string description, int price, int instock, string supplier) : base(pid, tittle, description, price, instock)
        {
            this.supplier = supplier;
        }
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        public static void initialize(List<Home> home)
        {


            Home f1 = new Home(1, "Vacuum Cleaner", "Vacuum Cleaner 2500W VC-EA300 Red/Black", 2005, 54, "Toshiba");
            Home f2 = new Home(2, "Coffee Machine", "One Cup Coffee Machine For Drip Coffee And Espresso With Coffee Mug 330W DCM25-B5 Black", 2005, 54, "BLACK+DECKER");
            Home f3 = new Home(2, "Air Fryer", "Air Fryer 1500W Af400-B5 Black Model Number: Af400-B5", 2005, 54, "Black&Decker");
            home.Add(f1);
            home.Add(f2);
            home.Add(f3);

        }
        public static void editstock(List<Home> home, int t)
        {
            foreach (var x in home)
            {
                if (x.Pid ==t)
                {
                    x.Instocks -= 1;
                }
            }



        }
        public static Home searchitem(List<Home> home, string t)
        {
            Home b = new Home();

            foreach (var x in home)
            {
                if (x.Tittle.Contains(t) == true)
                {
                    b = x;
                    break;
                }

            }

            return b;
        }
        public static Home search(List<Home> home, int id)
        {
            return home.Find(y => y.Pid == id);
        }
        public static bool bsearch(List<Home> home, int id)
        {
            bool y = false;
            foreach (var x in home)
            {
                if (x.Pid == id)
                    y = true;
            }

            return y;
        }
        public override string ToString()
        {
            return "Book Id: " + Pid + "\n" + "Tittle: " + Tittle + "\n" + "Author: " + Description + "\n" + "\n" + "Year Of Bublication: " + Price + "\n" + "instock" + Instocks+  "\n" + " supplier: " + Supplier;
        }


    }

}
