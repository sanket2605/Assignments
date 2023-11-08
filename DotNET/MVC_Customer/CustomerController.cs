using Microsoft.AspNetCore.Mvc;
using WB_Customer.Models;

namespace WB_Customer.Controllers
{
    public class CustomerController : Controller
    {
        ICustomer customer;
        
        public CustomerController(ICustomer cust) 
        {
            customer = cust;
        } 

        public ActionResult Index()
        {
            var customerlist = customer.GetAllCustomer();

            return View(customerlist);
        }
        public ActionResult Display()
        {
            return View();  
        }
    }
}
