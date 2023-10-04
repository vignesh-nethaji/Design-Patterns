
namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Abstract Factory
    public interface IPaymentFactory
    {
        IPaymentAuthorization CreateAuthorization();
        IPaymentTransfer CreateTransfer();
    }
}
