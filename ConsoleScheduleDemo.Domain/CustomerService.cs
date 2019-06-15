using System;
using ConsoleScheduleDemo.Repository;

namespace ConsoleScheduleDemo.Domain
{
    public class CustomerService
    {
        public CustomerService()
        {

        }


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
