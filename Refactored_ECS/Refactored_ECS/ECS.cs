﻿namespace Refactored_ECS
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

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
            {
                _heater.TurnOn();
            }
            else
            {
                _heater.TurnOff();
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
