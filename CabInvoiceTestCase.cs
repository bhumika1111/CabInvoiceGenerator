using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabinvoiceGenerator;

namespace CabInVoiceGeneratorUnitTest
{
    [TestClass]
    public class CabInvoiceTestCase
    { 
         InvoiceGenerator invoiceGenerator = null;
    
        [TestMethod]
        public void GivenDistanceTimeShouldReturnTotalFare() 
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}
