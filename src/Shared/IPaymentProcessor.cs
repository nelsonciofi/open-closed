namespace Shared;

public interface IPaymentProcessor
{
    bool ProcessPayment(PaymentContext paymentContext);
}