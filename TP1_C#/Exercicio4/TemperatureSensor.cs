using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_.Exercicio4
{
    internal class TemperatureSensor
    {
        public event EventHandler TemperatureExceeded;

        public void ReadTemperature(double temperature)
        {
            if (temperature > 100)
            {
                OnTemperatureExceeded(EventArgs.Empty);
            }
        }
        protected virtual void OnTemperatureExceeded(EventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }
    }
}
