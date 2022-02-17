using System;

namespace ECS.Legacy
{
    public class ECSClass
    {
        private int _threshold { get; set; }
        public ITempSensor _tempSensor { get; set; }
        private readonly IHeater _heater;


        public ECSClass(int thr)
        {
            _threshold=thr;
            _tempSensor = new TempSensor();
            _heater = new Heater();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

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
