using FullOpenClosed.Abstractions;
using Shared;

namespace FullOpenClosed.BankTypePaymentProcessors;

internal class BankAInstantTransferPaymentProcessor
    : IBankTypePaymentProcessor
{
    public BankType PaymentBankType
        => new(Bank.BankA, PaymentType.InstantTransfer);

    public bool ProcessPayment(PaymentContext paymentContext)
    {
        return true;
    }
}
