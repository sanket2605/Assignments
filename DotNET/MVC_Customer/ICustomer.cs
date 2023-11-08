namespace WB_Customer.Models
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomer(); 
    }
}
