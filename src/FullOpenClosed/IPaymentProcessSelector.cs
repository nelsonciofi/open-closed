using Shared;

namespace FullOpenClosed;

internal interface IPaymentProcessSelector
{
    IPaymentProcessor SelectPaymentProcessor(PaymentContext paymentContext);
}
