namespace FacadeMode.Utilities
{
    public class CarFacade
    {
        private readonly Engine _engine;
        private readonly Wheel[] _wheels;
        private readonly Braker _braker;

        public CarFacade()
        {
            _engine = new Engine();
            _wheels = new Wheel[4];
            for (int i = 0; i < _wheels.Length; i++)
            {
                _wheels[i] = new Wheel();
            }

            _braker = new Braker();
        }

        public void Run()
        {
            _engine.Start();
            foreach (var wheel in _wheels)
            {
                wheel.TurnOn();
            }
        }

        public void Brake()
        {
            _braker.Brake();
            foreach (var wheel in _wheels)
            {
                wheel.Stop();
            }
        }
    }
}