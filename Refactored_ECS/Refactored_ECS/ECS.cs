namespace Refactored_ECS
{
    public class ECS
    {
        private int _threshold;
        private readonly TempSensor.ITempSensor _tempSensor;
        private readonly Heater.IHeater _heater;

        public ECS(int thr, TempSensor.ITempSensor sensor, Heater.IHeater heater)
        {
            SetThreshold(thr);
            _tempSensor = sensor;
            _heater = heater;
        }

        public bool Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
            {
                _heater.TurnOn();
                return true;
            }
            else
            {
                _heater.TurnOff();
                return false;
            }


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
