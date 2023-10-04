
namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    public class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization() => new PayPalAuthorization();
        public IPaymentTransfer CreateTransfer() => new PayPalTransfer();
    }
}
