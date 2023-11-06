using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCustomer
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }

        /*public Customer(string name, string address, string mobileNo)
        {
        
            Name = name;
            Address = address;
            MobileNo = mobileNo;
        } */  
    }
}
