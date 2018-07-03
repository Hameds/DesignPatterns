using System;
namespace DesignPatterns.Structural.Adapter
{
    public class BitcoinPayment
    {
        public void DoTransaction(double price)
        {
            Console.WriteLine($"Paying {price.ToString("#,##")} Bitcoin");
        }
    }
}
