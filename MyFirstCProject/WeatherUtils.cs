using System;

namespace MyUtils
{
    class WeatherUtils
    {
        static float FarenheitToCelsius(float tempF)
        {
            return (tempF - 32) / 1.8f;
        }

        static float CelsiusToFarenheit(float tempC)
        {
            return (tempC * 1.8f) + 32;
        }

        //The higher the index the lower the comfort
        static float ComfortIndex(float tempF, float humidityPercent)
        {
            return (tempF + humidityPercent) / 4;
        }

        static void Report(string location, float tempC, float humidity)
        {
            var tempF = CelsiusToFarenheit(tempC);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(tempF, humidity)}");
        }
    }
}