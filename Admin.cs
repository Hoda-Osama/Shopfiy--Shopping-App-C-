using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Admin:Accounts
    {
        string name;


        public Admin() { }
        public Admin(int id, int pass, string name) : base(id, pass)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Admin(int id, int pass)
            : base(id, pass)
        {

        }

        public static int isadmin(Admin[] a, int id, int pass)
        {
            int x = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i].Id == id) && (a[i].Pass == pass))
                {
                    x = 1;
                    return x;
                }
            }
            return x;
        }
    }
}

