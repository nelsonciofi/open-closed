using Shared;

namespace FullOpenClosed.Abstractions;

internal interface IBankTypePaymentProcessor
{
    BankType PaymentBankType { get; }
    bool ProcessPayment(PaymentContext paymentContext);
}
