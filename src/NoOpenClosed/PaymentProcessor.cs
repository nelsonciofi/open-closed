using Shared;

namespace NoOpenClosed;

internal class PaymentProcessor : IPaymentProcessor
{
    public bool ProcessPayment(PaymentContext paymentContext)
    {
        switch (paymentContext.BankAccount.Bank)
        {
            case Bank.BankA:
                return ProcessPaymentForBankA(paymentContext);

            case Bank.BankB:
                return ProcessPaymentForBankB(paymentContext);

            default: return false;
        }
    }

    private static bool ProcessPaymentForBankA(PaymentContext paymentContext)
    {
        switch (paymentContext.PaymentType)
        {
            case PaymentType.InstantTransfer:
                return false;
            case PaymentType.SlowTransfer:
                return true;
            case PaymentType.Invoice:
                return true;
            case PaymentType.FastTransfer:
                return false;
            case PaymentType.Card:
                return true;

            default: return false;
        }
    }


    private static bool ProcessPaymentForBankB(PaymentContext paymentContext)
    {
        switch (paymentContext.PaymentType)
        {
            case PaymentType.InstantTransfer:
                return false;
            case PaymentType.SlowTransfer:
                return true;
            case PaymentType.Invoice:
                return true;
            case PaymentType.FastTransfer:
                return false;
            case PaymentType.Card:
                return true;

            default: return false;
        }
    }
}
