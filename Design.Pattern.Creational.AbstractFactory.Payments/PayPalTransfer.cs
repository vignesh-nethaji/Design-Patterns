using System;

namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    public class PayPalTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via PayPal...");
            return true; // Mocked success
        }
    }
}
