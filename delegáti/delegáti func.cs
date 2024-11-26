using System;

class Program
{
	static void Main()
	{

		Func<double, double, double> násob = Multiply;
		Console.WriteLine(Multiply(14, 5));
	}

	static double Multiply(double x, double y)
	{
		return x * y;
	}
}
