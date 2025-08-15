using PaymentAdapter.Payments.Adapters;
using PaymentAdapter.Payments.Services;
using PaymentAdapter.Payments;

IPaymentProcessor paypal = new PayPalAdapter(new PayPalService());
IPaymentProcessor stripe = new StripeAdapter(new StripeService());

var paymentService = new PaymentService();

paymentService.Process(paypal, 100m);
paymentService.Process(stripe, 50m);