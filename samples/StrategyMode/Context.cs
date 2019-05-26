namespace StrategyMode
{
    public class Context
    {
        private ICommunication _communication;

        public void SetStrategy(ICommunication communication)
        {
            _communication = communication;
        }

        public bool Send(object data)
        {
            return _communication.Send(data);
        }
    }
}