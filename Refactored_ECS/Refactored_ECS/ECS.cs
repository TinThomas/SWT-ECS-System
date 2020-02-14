namespace Refactored_ECS
{
    public class ECS
    {
        private int _threshold;
        private readonly TempSensor.TempSensor _tempSensor;
        private readonly Heater.Heater _heater;

        public ECS(int thr)
        {
            SetThreshold(thr);
            _tempSensor = new TempSensor.TempSensor();
            _heater = new Heater.Heater();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
