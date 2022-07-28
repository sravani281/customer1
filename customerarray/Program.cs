using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string state;
            string city;
            string add;
            int phone;
            int pincode;
            string email;
            Customer c;
            CustomerArray ca = new CustomerArray();
            while (true)
            {
                Console.WriteLine("Enter your choice\n1.Add Customer\n2.show All Customer\n3.Get Customer Id");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Name");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("State");
                        state = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("City");
                        city = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Address");
                        add = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Phone");
                        phone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("pincode");
                        pincode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("email");
                        email = Convert.ToString(Console.ReadLine());

                        int id = ca.Add(name, add, city, state, phone, email, pincode);
                        Console.WriteLine("Your Id is" + id);
                        break;
                    case 2:
                        ca.ShowALL();
                        break;
                    case 3:
                        Console.WriteLine("Enter your Id");
                        int i = Convert.ToInt32(Console.ReadLine());
                        c = ca[i];
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
                        break;


                }
            }
        }
    }
}
