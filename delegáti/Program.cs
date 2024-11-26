delegate int Operace(int x , int y);
class Program
{
	static void Main()
	{
		Operace operace = Scitej;
		Operace operace2 = Odcitej;
		Console.WriteLine(operace(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
		Console.WriteLine(operace2(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

	}
	static int Scitej(int x, int y)
	{
		return x + y;
	}
	static int Odcitej(int x, int y)
	{
		return x - y;
	}
}