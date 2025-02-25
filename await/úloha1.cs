using System.Threading;

class Program
{
	static async Task Main(string[] args)
	{
		Task synchronniOdpočet = AsyncFunction("odpocet", 10);
		await Task.WhenAll(synchronniOdpočet);
		Console.WriteLine("hotovo");
	}
	static async Task AsyncFunction(string name, int delay)
	{
		int x;
		for (int i = delay; i > 0; i--)
		{
			await Task.Delay(1000);
			x = i;
			Console.WriteLine($"zbývá {x} vteřin");
		}
	}


}