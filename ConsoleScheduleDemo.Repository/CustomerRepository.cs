using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleScheduleDemo.Repository
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
