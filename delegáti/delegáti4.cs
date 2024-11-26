using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{ 
			List<int> list = new List<int> {1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 123, 65, 546, 5644456};
		
		Predicate <int> sudý = Sudý;
		List<int> sudyNumbers = list.FindAll(sudý);
		Console.WriteLine(string.Join(", ", sudyNumbers));
	}
	static bool Sudý(int list)
	{
		return list % 2 == 0;
	}
}