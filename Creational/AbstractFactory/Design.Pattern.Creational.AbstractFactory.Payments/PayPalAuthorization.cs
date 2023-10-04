using System;

namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Concrete Products for PayPal
    public class PayPalAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via PayPal...");
            return true; // Mocked success
        }
    }
}
