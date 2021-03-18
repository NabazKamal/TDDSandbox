using System;
using Xunit;

namespace DomainTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
var customer = new Customer();
var allCustomers = customer.ListAll();
Assert.NotNull(allCustomers);
        }
    }
}
