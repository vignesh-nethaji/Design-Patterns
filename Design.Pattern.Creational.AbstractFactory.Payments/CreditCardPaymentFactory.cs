
namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Concrete Factories
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization() => new CreditCardAuthorization();
        public IPaymentTransfer CreateTransfer() => new CreditCardTransfer();
    }
}
