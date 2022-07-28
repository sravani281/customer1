using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace customerarray
{
    class CustomerArray
    {
        ArrayList CArray = new ArrayList();
        static int num = 0;
        static int i = 0;
        public Customer this[int i]
        {
            get
            {
                Customer temp = null;
                IEnumerator e;
                e = CArray.GetEnumerator();
                while (e.MoveNext())
                {
                    temp = (Customer)e.Current;
                    if (temp.Id == i)
                    {
                        break;
                    }
                }
                return temp;
            }
        }
        
        public int Add( string name, string address, string city, string state, int phone, string email, int pincode)
        {
            Customer c = new Customer();
         
            c.Name = name;
            c.Address = address;
            c.City = city;
            c.State = state;
            c.Phone = phone;
            c.Email = email;
            c.Pincode = pincode;
            c.Id = ++i;
            CArray.Add(c);
            return i;
        }
        public void ShowALL()
        {
            Customer c = null;
            IEnumerator e;
            e = CArray.GetEnumerator();
            while (e.MoveNext())
            {
                c = (Customer)e.Current;
                Console.WriteLine(".......................");
                Console.WriteLine("Customer id:" + c.Id);
                Console.WriteLine("Customer name" + c.Name);
                Console.WriteLine("Customer address" + c.Address);
                Console.WriteLine("Customer state" + c.State);
                Console.WriteLine("Customer City" + c.City);
                Console.WriteLine("Customer Phone" + c.Phone);
                Console.WriteLine("Customer Pincode" + c.Pincode);
                Console.WriteLine("Customer Email" + c.Email);
                Console.WriteLine("............");
            }
        }
    }
}
