using FullOpenClosed.Abstractions;
using Shared;

namespace FullOpenClosed;

internal sealed class PaymentProcessor : IPaymentProcessor
{
    private readonly IPaymentProcessSelector paymentProcessSelector;

    public PaymentProcessor(IPaymentProcessSelector paymentProcessSelector)
    {
        this.paymentProcessSelector = paymentProcessSelector;
    }

    public bool ProcessPayment(PaymentContext paymentContext)
    {
        return paymentProcessSelector.SelectPaymentProcessor(paymentContext)
                                     .ProcessPayment(paymentContext);        
    }
}