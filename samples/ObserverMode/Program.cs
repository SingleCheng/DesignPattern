using System;

namespace ObserverMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Observer Mode Demo");

            var creditCard = new CreditCard();
            var sms = new SmsNotify();
            var account = new Account(1000);
            creditCard.SpendMoney += account.Update;
            creditCard.SpendMoney += sms.Update;
            creditCard.SpendAmount = 200;
        }
    }
}