using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class Accounts
    {
        private int id;
        private int pass;

        public Accounts() { }
        public Accounts(int id, int pass)
        {
            this.id = id;
            this.pass = pass;


        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public int Pass
        {
            get { return pass; }
            set
            {
                pass = value;
            }
        }

        public override string ToString()
        {
            return " Id: " + id + "\n";
        }
    }
}

