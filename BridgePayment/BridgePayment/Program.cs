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

public abstract class PaymentSystem : IPaymentSystem
{
    protected IPaymentSystemImplementor _paymentSystemImplementor;

    public PaymentSystem(IPaymentSystemImplementor paymentSystemImplementor)
    {
        _paymentSystemImplementor = paymentSystemImplementor;
    }

    public abstract void ProcessPayment(double amount);
}

public class ATMPaymentSystem : PaymentSystem
{
    public ATMPaymentSystem(IPaymentSystemImplementor paymentSystemImplementor) 
        : base(paymentSystemImplementor)
    {

    }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment with an ATM");
        _paymentSystemImplementor.ProcessPayment(amount);
    }
}

public class PayPalPaymentSystem : PaymentSystem
{
    public PayPalPaymentSystem(IPaymentSystemImplementor paymentSystemImplementor) 
        : base(paymentSystemImplementor)
    {
    }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment with Pay Pal");
        _paymentSystemImplementor.ProcessPayment(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPaymentSystemImplementor creditCardImplementor = new CreditCardPayment();
        IPaymentSystemImplementor payPalImplementor = new PayPalPayment();

        IPaymentSystem creditCardPaymentSystem = new ATMPaymentSystem(creditCardImplementor);
        IPaymentSystem payPalPaymentSystem = new PayPalPaymentSystem(payPalImplementor);

        creditCardPaymentSystem.ProcessPayment(100);
        payPalPaymentSystem.ProcessPayment(50);
    }
}