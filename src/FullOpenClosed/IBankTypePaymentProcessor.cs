using Shared;

namespace FullOpenClosed;

internal interface IBankTypePaymentProcessor
{
    BankType PaymentBankType { get; }
    bool ProcessPayment(PaymentContext paymentContext);
}
