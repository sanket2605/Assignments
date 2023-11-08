namespace WB_Customer.Models
{
    public class ServiceCustomer : ICustomer
    {
        private static List<Customer> customerlist;
        public ServiceCustomer()
        {
            customerlist = new List<Customer>()
            {
                new Customer() {CustomerId=1,CustomerName="Rohit",MobileNo=99999,BillAmount=69000},
                new Customer() {CustomerId=2,CustomerName="Shantanu",MobileNo=88888,BillAmount=55000},
                new Customer() {CustomerId=3,CustomerName="Anup",MobileNo=77777,BillAmount=17000},
                new Customer() {CustomerId=4,CustomerName="Nikhil",MobileNo=66666,BillAmount=15000},
            };
        }
        public IEnumerable<Customer> GetAllCustomer()
        {
            return customerlist;

        }
    }
}
