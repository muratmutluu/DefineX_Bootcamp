namespace ReflectionPaymentMethod.PaymentMethods
{
    public class Nakit : IPaymentMethod
    {
        public string MakePayment(double amount)
        {
            return $"Nakit ödeme yapıldı. Ödenen tutar: {amount:C2}";
        }
    }
}
