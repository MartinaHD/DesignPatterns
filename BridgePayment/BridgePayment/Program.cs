using System;

public interface IPaymentSystem
{
    void ProcessPayment(double amount);
}

public interface IPaymentSystemImplementor
{
    void ProcessPayment(double amount);
}

public class CreditCardPayment : IPaymentSystemImplementor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment: ${amount}");
    }
}

public class PayPalPayment : IPaymentSystemImplementor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment: ${amount}");
    }
}

public class PaymentSystemAdapter : IPaymentSystem
{
    private IPaymentSystemImplementor _implementor;

    public PaymentSystemAdapter(IPaymentSystemImplementor implementor)
    {
        _implementor = implementor;
    }

    public void ProcessPayment(double amount)
    {
        _implementor.ProcessPayment(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPaymentSystemImplementor creditCardImplementor = new CreditCardPayment();
        IPaymentSystemImplementor payPalImplementor = new PayPalPayment();


        IPaymentSystem creditCardPaymentSystem = new PaymentSystemAdapter(creditCardImplementor);
        IPaymentSystem payPalPaymentSystem = new PaymentSystemAdapter(payPalImplementor);

        creditCardPaymentSystem.ProcessPayment(100);
        payPalPaymentSystem.ProcessPayment(50);
    }
}