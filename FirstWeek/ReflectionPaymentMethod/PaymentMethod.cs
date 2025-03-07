namespace ReflectionPaymentMethod
{
    public class PaymentMethod
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public string MakePayment(double amount)
        {
            return _paymentMethod.MakePayment(amount);
        }
    }
}
