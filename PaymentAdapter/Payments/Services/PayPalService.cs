using PaymentAdapter.Payments.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapter.Payments.Services
{
    public class PayPalService : IPaymentPlatformService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"[PayPal] Pagamento de R$ {amount:F2} processado.");
        }
    }
}
