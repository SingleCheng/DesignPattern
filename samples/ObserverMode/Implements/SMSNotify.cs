using System;

namespace ObserverMode.Implements
{
    public class SmsNotify : Interfaces.IObserver<CreditCard>
    {
        public void Update(object sender, CreditCard e)
        {
            Console.WriteLine("Sms notify.Spend {0}", e.SpendAmount);
        }
    }
}