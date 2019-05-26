using System;

namespace ObserverMode
{
    public class CreditCard : EventArgs
    {
        private float _spendAmount;
        public event EventHandler<CreditCard> SpendMoney;

        public float SpendAmount
        {
            get => _spendAmount;
            set
            {
                _spendAmount = value;
                Notify();
            }
        }

        private void Notify()
        {
            SpendMoney?.Invoke(this, this);
        }
    }
}