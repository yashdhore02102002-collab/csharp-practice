using System;

interface IPayment
{
    void ProcessPayment(double amount);
    void PrintReceipt();
}
class CreditCard : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Credit card payment processed: ₹" + amount);
    }
    public void PrintReceipt()
    {
        Console.WriteLine("Credit Card Receipt Printed..");
    }
}
class UPI : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("UPI payment processed : ₹" + amount);

    }
    public void PrintReceipt()
    {
        Console.WriteLine("UPI Receipt Printed..");
    }
}
class Program
{
    static void Main()
    {
        IPayment payment1 = new CreditCard();
        Console.WriteLine("Enter Amount for debit in Credit card: ₹");
        double amount = double.Parse(Console.ReadLine());
        payment1.ProcessPayment(amount);
        payment1.PrintReceipt();

        Console.WriteLine("-----");

        IPayment payment2 = new UPI();
        Console.WriteLine("Enter Amount for debit in UPI: ₹" );
        double amount1 = double.Parse(Console.ReadLine());
        payment2.ProcessPayment(amount1);
        payment2.PrintReceipt();
        
        
    }
}