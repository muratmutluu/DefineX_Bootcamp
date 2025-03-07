namespace ReflectionPaymentMethod
{
    public interface IPaymentMethod
    {
        string MakePayment(double amount);
    }
}
