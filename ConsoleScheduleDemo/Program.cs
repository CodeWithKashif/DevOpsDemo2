using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScheduleDemo.Domain;

namespace ConsoleScheduleDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is demo console app!");
            Console.WriteLine(new CustomerService().GetCustomerName());
            Console.WriteLine(new CustomerService().GetCustomerNameFromRepo());
            Console.WriteLine("Finished");
            //Console.ReadKey();
        }
    }
}
