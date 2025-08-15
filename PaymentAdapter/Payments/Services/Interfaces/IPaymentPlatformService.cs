using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAdapter.Payments.Services.Interfaces
{
    public interface IPaymentPlatformService
    {
        public void Pay(decimal amount);
    }
}
