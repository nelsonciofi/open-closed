namespace Shared;

public class PaymentContext
{
    public BankAccount BankAccount { get; set; }
    public PaymentType PaymentType { get; set; }
    public Bill[] Bills { get; set; }

    public PaymentContext(BankAccount bankAccount,
                          Bill[] bills,
                          PaymentType paymentType)
    {
        BankAccount = bankAccount;
        Bills = bills;
        PaymentType = paymentType;
    }
}