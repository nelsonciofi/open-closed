using FullOpenClosed.Abstractions;

namespace FullOpenClosed;

internal class SingleDependencyBankType
{
    private readonly IBankTypePaymentProcessor bankTypePaymentProcessor;

    public SingleDependencyBankType(IBankTypePaymentProcessor bankTypePaymentProcessor)
    {
        this.bankTypePaymentProcessor = bankTypePaymentProcessor;
    }
}