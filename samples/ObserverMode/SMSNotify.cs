using System;

namespace ObserverMode
{
    public class SmsNotify : IObserver<CreditCard>
    {
        public void Update(object sender, CreditCard e)
        {
            Console.WriteLine("Sms notify.Spend {0}", e.SpendAmount);
        }
    }
}