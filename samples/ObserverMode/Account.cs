using System;

namespace ObserverMode
{
    public class Account : IObserver<CreditCard>
    {
        private float _accountAmount;

        public Account(float accountAmount)
        {
            _accountAmount = accountAmount;
        }

        public void Update(object sender, CreditCard e)
        {
            _accountAmount += e.SpendAmount;
            Console.WriteLine("Account amount is {0}", _accountAmount);
        }
    }
}