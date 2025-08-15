using PaymentAdapter.Payments.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapter.Payments.Services
{
    public class PaymentService
    {
        public void Process(IPaymentProcessor processor, decimal amount)
        {
            processor.ProcessPayment(amount);
        }
    }
}
