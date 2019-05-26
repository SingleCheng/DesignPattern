using BridgeMode.Interfaces;

namespace BridgeMode.Model
{
    public abstract class Car
    {
        private readonly IEngine _engine;

        protected Car(IEngine engine)
        {
            _engine = engine;
        }

        public virtual void Start()
        {
            _engine.Start();
        }

        public virtual void Stop()
        {
            _engine.Stop();
        }
    }
}