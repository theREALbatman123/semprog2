using System;

class Program
{
	static void Main()
	{
		Action<string> vytiskniZprávu = Tiskni;
		vytiskniZprávu("Pepek námořník");
	}

	static void Tiskni(string message)
	{
		Console.WriteLine(message);
	}
}