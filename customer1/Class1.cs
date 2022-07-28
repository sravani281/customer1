using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer1
{
    public class Customer
    {
        protected int cust_id;
        protected string cust_name;
        protected string cust_address;
        protected int cust_phone;
        protected string cust_city;
        protected string cust_state;
        protected int cust_pincode;
        protected string cust_email;
        public int Cust_Id
        {
            get
            {
                return cust_id;
            }
            set
            {
                cust_id = value;
            }
        }
        public string Cust_Name
        {
            get
            {
                return cust_name;
            }
            set
            {
                cust_name = value;
            }
        }
        public string Cust_Address
        {
            get
            {
                return cust_address;
            }
            set
            {
                cust_address = value;
            }
        }
        public int Cust_Phone
        {
            get
            {
                return cust_phone;
            }
            set
            {
                cust_phone = value;
            }
        }
    }
}
