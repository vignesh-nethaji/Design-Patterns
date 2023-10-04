
namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Abstract Products
    public interface IPaymentAuthorization
    {
        bool AuthorizePayment(decimal amount);
    }
}
