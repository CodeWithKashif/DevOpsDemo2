using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDevOps.Domain;

namespace ConsoleAppDevOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is new demo console app!");
            Console.WriteLine(new CustomerService().GetCustomerName());
            Console.WriteLine(new CustomerService().GetCustomerNameFromRepo());
            Console.WriteLine("Finished");
        }
    }
}
