using System;

namespace StrategyMode
{
    public class Lan : ICommunication
    {
        public bool Send(object data)
        {
            Console.WriteLine("通過Lan 發送一個演算法");
            return true;
        }
    }
}