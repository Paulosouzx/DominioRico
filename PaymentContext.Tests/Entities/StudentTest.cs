using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Paulo", "Junior", "15759217666", "paulosouzx14@gmail.com");
            
        }
    }
}