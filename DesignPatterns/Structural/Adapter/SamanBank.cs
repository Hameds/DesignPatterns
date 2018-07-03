using System;
namespace DesignPatterns.Structural.Adapter
{
    public class SamanBank : IIranianBank
    {
        public void Payment(double price)
        {
            Console.WriteLine($"Paying {price.ToString("#,##")} Rial via Saman Bank");
        }
    }
}
