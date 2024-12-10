using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Console.WriteLine("Otestuj si svůj palindrom zde: ");
		string vstup = Console.ReadLine().ToLower().Replace(" ", "");
		Queue<char> palindromy = new Queue<char>();
		foreach (char pismenko in vstup)
		{
			palindromy.Enqueue(pismenko);
		}
		bool totoPalindromJest = true;
		int x = 0;
		int y = palindromy.Count - 1;

		while (x < y)
		{
			if (palindromy.Dequeue() != vstup[y])
			{
				totoPalindromJest = false;
				break;
			}
			x++;
			y--;
		}
		if (totoPalindromJest)
		{
			Console.WriteLine("Toto palindromem jest!!");
		}
		else
		{
			Console.WriteLine("Toto palindrom není");
		}
	}
}


		