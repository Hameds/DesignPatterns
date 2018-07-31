using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    class CashPayment : IMoney
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"You payed {amount} ");
        }
    }
}
