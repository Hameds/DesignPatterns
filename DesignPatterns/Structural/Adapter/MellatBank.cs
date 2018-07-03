using System;
namespace DesignPatterns.Structural.Adapter
{
    public class MellatBank : IIranianBank
    {
        public void Payment(double price)
        {
            Console.WriteLine($"Paying {price.ToString("#,##")} Rial via Mellat Bank");
        }
    }
}
