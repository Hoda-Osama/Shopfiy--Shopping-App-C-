using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Elec:Product
    {
        string supplier;
        private static List<Elec> p = new List<Elec>();
        public static List<Elec> P
        {
            get { return p; }
        }
        public Elec() { }
        public Elec(int pid, string tittle, string description, int price, int instock, string supplier) : base(pid, tittle, description, price, instock)
        {
            this.supplier = supplier;
        }
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        public static void initialize(List<Elec> elec)
        {


            Elec f1 = new Elec(1, "Ceiling Fan", "Silent Action Ceiling Fan TCF56BW White Model Number: TCF56BW", 2005, 54, "Tornado");
            Elec f2 = new Elec(2, "Laptop", "IdeaPad L340 Laptop With 15.6-Inch Display, Core i3 Processor/4GB RAM/1TB HDD/2GB NVIDIA GeForce MX110 Graphics Card Abyss Blue", 2005, 54, "Lenovo");
            Elec f3 = new Elec(3, "iPhone 11", "iPhone 11 With FaceTime White 64GB 4G LTE -", 2005, 54, "Apple");
           
            elec.Add(f1);
            elec.Add(f2);
            elec.Add(f3);
           

        }
        public static void editstock(List<Elec> elec, int t)
        {
            foreach (var x in elec)
            {
                if (x.Pid==t)
                {
                    x.Instocks -= 1;
                }
            }



        }
        public static Elec searchitem(List<Elec> elec, string t)
        {
            Elec b = new Elec();

            foreach (var x in elec)
            {
                if (x.Tittle.Contains(t) == true)
                {
                    b = x;
                    break;
                }

            }

            return b;
        }
        public static Elec search(List<Elec> elec, int id)
        {
            return elec.Find(y => y.Pid == id);
        }
        public static bool bsearch(List<Elec> elec, int id)
        {
            bool y = false;
            foreach (var x in elec)
            {
                if (x.Pid == id)
                    y = true;
            }

            return y;
        }
        public override string ToString()
        {
            return "Book Id: " + Pid + "\n" + "Tittle: " + Tittle + "\n" + "Author: " + Description + "\n" + "\n" + "Year Of Bublication: " + Price + "\n" + "instock" + Instocks + "\n" + " supplier: " + Supplier;
        }
    }
}
