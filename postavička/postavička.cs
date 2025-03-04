int x = 7;
int y = 6;
int n;
int m;
n = x;
m = y;

while (true)
{


	
	Console.Write("A");
	Console.ReadKey();


	if (Console.KeyAvailable)
	{
		Console.SetCursorPosition(x, y);
		var key = Console.ReadKey(true).Key;

		switch (key)
		{

			case ConsoleKey.UpArrow: if (y > 0) y--; break;
			case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
			case ConsoleKey.LeftArrow: if (x > 0) x--; break;
			case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
				
		}

	}

	
		
		
	Console.Write(" ");
	Console.ReadKey();


	
	
}
