using PaymentAdapter.Payments.Adapters;
using PaymentAdapter.Payments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapterTest.Payments.Adapters
{
    public class PayPalAdapterTest
    {
        [Fact]
        public void ProcessPayment_Should_Call_MakePayment()
        {
            // Arrange
            var payPalService = new PayPalService();
            var adapter = new PayPalAdapter(payPalService);
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            adapter.ProcessPayment(100m);

            // Assert
            var output = sw.ToString().Trim();
            Assert.Equal("[PayPal] Pagamento de R$ 100.00 processado.", output);
        }
    }
}
