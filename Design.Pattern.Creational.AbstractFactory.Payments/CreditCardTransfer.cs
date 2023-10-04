using System;

namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    public class CreditCardTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via Credit Card...");
            return true; // Mocked success
        }
    }
}
