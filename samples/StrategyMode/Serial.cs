using System;

namespace StrategyMode
{
    public class Serial : ICommunication
    {
        public bool Send(object data)
        {
            Console.WriteLine("通過Serial 發送一個演算法");
            return true;
        }
    }
}