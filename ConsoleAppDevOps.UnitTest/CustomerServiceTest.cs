using System;
using ConsoleAppDevOps.Domain;
using NUnit.Framework;

namespace ConsoleAppDevOps.UnitTest
{
    [TestFixture]
    public class CustomerServiceTest
    {
        [Test]
        public void CallGetCustomerName_ShouldReturnByDomain()
        {
            var customerService = new CustomerService();
            Assert.That(customerService.GetCustomerName().Contains("This is from domain"));
        }

        [Test]
        public void CallGetCustomerName_ShouldReturnByRepository()
        {
            var customerService = new CustomerService();
            Assert.That(customerService.GetCustomerNameFromRepo().Contains("This is from repository"));
        }
    }
}
