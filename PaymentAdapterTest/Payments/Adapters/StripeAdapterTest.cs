using PaymentAdapter.Payments.Adapters;
using PaymentAdapter.Payments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapterTest.Payments.Adapters
{
    public class StripeAdapterTest
    {
        [Fact]
        public void ProcessPayment_Should_Call_Charge()
        {
            // Arrange
            var stripeService = new StripeService();
            var adapter = new StripeAdapter(stripeService);
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            adapter.ProcessPayment(50m);

            // Assert
            var output = sw.ToString().Trim();
            Assert.Equal("[Stripe] Pagamento de R$ 50.00 processado.", output);
        }
    }
}
