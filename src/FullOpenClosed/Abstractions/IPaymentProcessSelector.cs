using Shared;

namespace FullOpenClosed.Abstractions;

internal interface IPaymentProcessSelector
{
    IBankTypePaymentProcessor SelectPaymentProcessor(PaymentContext paymentContext);
}
