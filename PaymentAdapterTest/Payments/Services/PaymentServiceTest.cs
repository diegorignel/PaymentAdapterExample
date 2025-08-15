using PaymentAdapter.Payments.Services;
using PaymentAdapter.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PaymentAdapterTest.Payments.Services
{
    public class PaymentServiceTest
    {
        [Fact]
        public void Process_Should_Call_ProcessPayment_On_Processor()
        {
            // Arrange
            var mockProcessor = new Mock<IPaymentProcessor>();
            var service = new PaymentService();

            // Act
            service.Process(mockProcessor.Object, 200m);

            // Assert
            mockProcessor.Verify(p => p.ProcessPayment(200m), Times.Once);
        }
    }
}
