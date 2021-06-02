using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoda_17100682_FinalProject
{
    class User:Accounts
    {
        private static List<User> users = new List<User>();
        public static List<User> Us
        {
            get { return users; }
        }
        string status;
        string name;
        string address;
        string phone;
        string email;

        public User() { }
        public User(int id, string name, int pass, string status,string phone, string address, string email)
            : base(id, pass)
        {
            this.status = status;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;

        }
        public User(int id, int pass)
            : base(id, pass)
        {

        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "Name:" + name + "\n" + "Pssword:" + Pass;
        }
        public static int isuser(List<User> u, int id, int pass)
        {
            int x = -1;
            if (u.Exists(y => y.Id == id) == true && u.Exists(z => z.Pass == pass) == true)

            {
                x = 1;
                return x;
            }
            else
                return x;
        }
        public static User user(List<User> u, int id)
        {

            return u.Find(y => y.Id == id);
        }


        public static void initialize(List<User> user)
        {


            User a0 = new User(1, "hoda", 123, "Student","01025","123 Pjh","xxx@g.com");
            User a1 = new User(2, "hoda", 123, "Graduate", "01025", "123 Pjh", "xxx@g.com");
            user.Add(a0);
            user.Add(a1);



        }
        public static int generateid(List<User> users)
        {
            int x = 1;
            bool m;
            for (int i = 1; i < 100; i++)
            {
                m = users.Exists(y => y.Id == i);
                if (m == false)
                {
                    x = i;
                    break;
                }

            }
            return x;
        }
        public static void adduser(List<User> users, User newuser)
        {
            users.Add(newuser);

        }

    }

}
