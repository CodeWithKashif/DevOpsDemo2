using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDevOps.Repository;

namespace ConsoleAppDevOps.Domain
{
    /// <summary>
    /// Here is the comment goess
    /// </summary>
    public class CustomerService
    {
        public string GetCustomerName()
        {
            return "This is from domain - " + DateTime.Now.ToLongDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }

        public string GetCustomerNameFromRepo()
        {
            return new CustomerRepository().GetCustomerFromRepository();
        }
    }
}
