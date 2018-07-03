using System;
namespace DesignPatterns.Structural.Adapter
{
    public class Shop
    {
        public void Purchase(IIranianBank bank, double price)
        {
            bank.Payment(price);
        }
    }
}
