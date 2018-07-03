using System;
namespace DesignPatterns.Structural.Adapter
{
    public class BitcoinAdapter : IIranianBank
    {
        private BitcoinPayment _bitcoinPay;
        public BitcoinAdapter(BitcoinPayment bitcoinPay)
        {
            this._bitcoinPay = bitcoinPay;
        }
        public void Payment(double price)
        {
            var convertedPrice = price / 1000;
            _bitcoinPay.DoTransaction(convertedPrice);
        }
    }
}
