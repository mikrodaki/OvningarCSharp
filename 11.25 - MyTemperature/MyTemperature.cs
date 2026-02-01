using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._25___MyTemperature
{
	class MyTemperature
	{
		/*
		* IsBoiling
		* 
		* Takes a fahrenheit temperature and returns
		* true if the water is boiling, false otherwise
		* 
		*/
		public static bool IsBoiling(int fahrenheit)
		{
			if (fahrenheit < 212)
				return false;

			return true;
		}

		/*
         * IsBoiling
         * 
         * Takes a fahrenheit temperature and returns
         * true if the water is boiling, false otherwise
         * 
         */
		public static bool IsBoiling(float fahrenheit)
		{
			if (fahrenheit < 212)
				return false;

			return true;
		}

		/*
         * CelsiusToFahrenheit
         * 
         * Returns the fahrenheit value of a celcius temperature.
         * 
         */
		public static int CelsiusToFahrenheit(int celsius)
		{
			return (int)CelsiusToFahrenheitPrivate(celsius);
		}

		/*
         * CelsiusToFahrenheit
         * 
         * Returns the fahrenheit value of a celcius temperature.
         * 
         */
		public static float CelsiusToFahrenheit(float celsius)
		{
			return (float)CelsiusToFahrenheitPrivate(celsius);
		}

		private static double CelsiusToFahrenheitPrivate(double celsius) 
		{
			return ((celsius * 9) / 5) + 32;
		}


	}
}
