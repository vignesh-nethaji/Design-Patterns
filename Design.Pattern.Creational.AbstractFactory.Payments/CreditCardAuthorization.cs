using System;

namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Concrete Products for Credit Card
    public class CreditCardAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via Credit Card...");
            return true; // Mocked success
        }
    }
}
