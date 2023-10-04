using System;

namespace Design.Pattern.Creational.AbstractFactory.Payments
{
    // Testing the Abstract Factory Design Pattern
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Processing payment using Credit Card:");
            var creditCardFactory = new CreditCardPaymentFactory();
            var creditCardProcessor = new PaymentProcessor(creditCardFactory);
            creditCardProcessor.ProcessPayment(100.00M);

            Console.WriteLine("\nProcessing payment using PayPal:");
            var payPalFactory = new PayPalPaymentFactory();
            var payPalProcessor = new PaymentProcessor(payPalFactory);
            payPalProcessor.ProcessPayment(100.00M);

            Console.ReadKey();
        }
    }
}
