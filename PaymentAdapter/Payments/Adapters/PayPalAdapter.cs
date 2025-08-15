using PaymentAdapter.Payments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapter.Payments.Adapters
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalService _payPalService;

        public PayPalAdapter(PayPalService payPalService)
        {
            _payPalService = payPalService;
        }

        public void ProcessPayment(decimal amount)
        {
            _payPalService.Pay(amount);
        }
    }
}
