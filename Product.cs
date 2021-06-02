using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Product
    {
        int pid;
        string tittle;
        string description;
        int price;
        int instock;
        public Product() { }
        public Product(int pid, string tittle, string description, int price, int instock)
        {
            this.pid = pid;
            this.tittle = tittle;
            this.description = description;
            this.price = price;
            this.instock = instock;
        }
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Instocks
        {
            get { return instock; }
            set { instock = value; }
        }
        public override string ToString()
        {
            return "Book Id: " + Pid + "\n" + "Tittle: " + Tittle + "\n" + "Author: " + Description + "\n"  + "\n" + "Year Of Bublication: " + Price + "\n" + "instock" + Instocks;
        }

    }
}
