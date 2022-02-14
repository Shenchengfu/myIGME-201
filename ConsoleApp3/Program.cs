using System;

namespace ConsoleApp3
{
	delegate double round(double x, int y);

	class Demo
	{
		public static double round(double value, int digit)
		{
			return Math.round(value, digit);
		}
	}
