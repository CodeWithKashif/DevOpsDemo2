using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevOps.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {

        }
        public string GetCustomerFromRepository()
        {
            return "This is from repository -- " + DateTime.Now.ToLongDateString() + " -- " + DateTime.Now.ToLongTimeString();
        }
    }
}
