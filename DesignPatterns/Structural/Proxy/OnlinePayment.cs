using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    class OnlinePayment
    {
        private IMoney _bankMoney;

        public OnlinePayment(IMoney money)
        {
            _bankMoney = money;
        }

        public void Pay(int amount)
        {
            if (CanPay(amount))
            {
                _bankMoney.Pay(amount);
            }
            else
            {
                Console.WriteLine("You can't pay more that 10000");
            }
        }

        private bool CanPay(int amount)
        {
            return amount < 10000 ? true : false;
        }
    }
}
