using System;
using MyUtils;

namespace MyFirstCProject
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in August?");
            WeatherUtils.Report("San Francisco", WeatherUtils.FarenheitToCelsius(65), 70);
            WeatherUtils.Report("London",      14, 30);
        }
    }
}
        