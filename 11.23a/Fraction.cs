using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._23a
{
	class Fraction
	{
		public static void Add(int a, int b, int c, int d, ref int inumerator, ref int denumerator)
		{
			inumerator = a * d + c * b;
			denumerator = b * d;
			FixDoubleNegative(ref inumerator, ref denumerator);
		}

		public static void Subtract(int a, int b, int c, int d, ref int inumerator, ref int denumerator)
		{
			inumerator = a * d - c * b;
			denumerator = b * d;
			FixDoubleNegative(ref inumerator, ref denumerator);
		}

		public static void Multiply(int a, int b, int c, int d, ref int inumerator, ref int denumerator)
		{
			inumerator = a * c;
			denumerator = b * d;
			FixDoubleNegative(ref inumerator, ref denumerator);
		}

		public static void Divide(int a, int b, int c, int d, ref int inumerator, ref int denumerator)
		{
			inumerator = a * d;
			denumerator = b * c;
			FixDoubleNegative(ref inumerator, ref denumerator);
		}

		private static void FixDoubleNegative(ref int inumerator, ref int denumerator)
		{
			if (inumerator < 0 && denumerator < 0)
			{
				inumerator = Math.Abs(inumerator);
				denumerator = Math.Abs(denumerator);
			}
		}
	}
}
