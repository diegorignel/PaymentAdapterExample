using PaymentAdapter.Payments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapter.Payments.Adapters
{
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly StripeService _stripeService;

        public StripeAdapter(StripeService stripeService)
        {
            _stripeService = stripeService;
        }

        public void ProcessPayment(decimal amount)
        {
            _stripeService.Pay(amount);
        }
    }
}
