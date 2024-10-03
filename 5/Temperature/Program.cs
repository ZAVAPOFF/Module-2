using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    // Класс для хранения данных о температуре
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double Temperature { get; }

        public TemperatureChangedEventArgs(double temperature)
        {
            Temperature = temperature;
        }
    }

    // Класс датчика температуры
    public class TemperatureSensor
    {
        private double _currentTemperature;

        // Событие, которое будет генерироваться при изменении температуры
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // Метод для изменения температуры (например, симуляция измерения температуры)
        public void SetTemperature(double newTemperature)
        {
            if (Math.Abs(newTemperature - _currentTemperature) > 0.01)
            {
                _currentTemperature = newTemperature;
                OnTemperatureChanged(new TemperatureChangedEventArgs(_currentTemperature));
            }
        }

        // Метод для вызова события TemperatureChanged
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // Класс термостата
    public class Thermostat
    {
        private readonly double _targetTemperature;

        public Thermostat(double targetTemperature)
        {
            _targetTemperature = targetTemperature;
        }

        // Метод для подписки на событие
        public void Subscribe(TemperatureSensor sensor)
        {
            sensor.TemperatureChanged += OnTemperatureChanged;
        }

        // Реакция на изменение температуры
        private void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            if (e.Temperature < _targetTemperature)
            {
                Console.WriteLine($"Температура {e.Temperature}°C слишком низкая. Включаем отопление.");
            }
            else
            {
                Console.WriteLine($"Температура {e.Temperature}°C достаточно высокая. Отключаем отопление.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Создаем датчик температуры и термостат
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat(22.0); // Целевая температура 22°C

            // Подписываем термостат на событие изменения температуры
            thermostat.Subscribe(sensor);

            // Изменяем температуру
            sensor.SetTemperature(20.0);
            sensor.SetTemperature(23.0);
            sensor.SetTemperature(21.5);
            Console.ReadLine();
        }
    }

}
