using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    class TemperatureTracker
    {
        private double[] temperatures;

        public TemperatureTracker(int numDays)
        {
            temperatures = new double[numDays];
        }

        public void SetTemperature(int day, double temperature)
        {
            temperatures[day - 1] = temperature;
        }

        public void DisplayWeeklyTemperatures()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days:");
            int numDays = int.Parse(Console.ReadLine());

            TemperatureTracker tracker = new TemperatureTracker(numDays);

            for (int i = 0; i < numDays; i++)
            {
                Console.WriteLine($"Enter temperature for Day {i + 1}:");
                double temperature = double.Parse(Console.ReadLine());
                tracker.SetTemperature(i + 1, temperature);
            }

        }
    }
}
