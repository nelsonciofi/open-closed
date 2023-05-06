using FullOpenClosed.Abstractions;
using Shared;

namespace FullOpenClosed;

internal class PaymentProcessSelector : IPaymentProcessSelector
{
    private readonly Dictionary<BankType, IBankTypePaymentProcessor> bankTypePaymentProcessors = new();

    public PaymentProcessSelector(IEnumerable<IBankTypePaymentProcessor> bankTypePaymentProcessors)
    {
        foreach (var processor in bankTypePaymentProcessors)
        {
            if (!this.bankTypePaymentProcessors.TryAdd(processor.PaymentBankType, processor))
            {
                throw new ArgumentException($"There are more than one processor for {processor.PaymentBankType}.");
            }         
        }
    }

    public IBankTypePaymentProcessor SelectPaymentProcessor(PaymentContext paymentContext)
    {
        var bankType = new BankType(paymentContext.BankAccount.Bank, paymentContext.PaymentType);

        if (!bankTypePaymentProcessors.TryGetValue(bankType, out var processor))
        {
            throw new ArgumentException($"A payment processor for {bankType} is not available.");
        }

        return processor;
    }
}