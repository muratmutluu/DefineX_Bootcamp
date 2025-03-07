namespace ReflectionPaymentMethod.PaymentMethods
{
    public class ApplePay : IPaymentMethod
    {
        public string MakePayment(double amount)
        {
            return $"Apple Pay ile ödeme yapıldı. Ödenen tutar: {amount:C2}";
        }
    }
}
