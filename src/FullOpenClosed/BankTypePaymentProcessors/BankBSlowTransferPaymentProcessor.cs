using FullOpenClosed.Abstractions;
using Shared;

namespace FullOpenClosed.BankTypePaymentProcessors;

internal class BankBSlowTransferPaymentProcessor
    : IBankTypePaymentProcessor
{
    public BankType PaymentBankType
        => new(Bank.BankB, PaymentType.SlowTransfer);

    public bool ProcessPayment(PaymentContext paymentContext)
    {
        return false;
    }
}
