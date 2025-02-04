Stack<char> zásobník = new Stack<char>();
Console.WriteLine("Napiš závorky:");
string závorky = Console.ReadLine();
char[] znaky = závorky.ToArray();

foreach (char c in znaky)
{
	if (c == '(' || c == '{' || c == '[' || c == ')' || c == '}' || c == ']')
	{
		if (c == '(' || c == '{' || c == '[')
		{
			zásobník.Push(c);
		}

		if (c == ')')
		{
			if (zásobník.Peek() == '(')
			{
				zásobník.Pop();
			}
			else
			{
				Console.WriteLine("Chyba!");
			}
		}

		else if (c == '}')
		{
			if (zásobník.Peek() == '{')
			{
				zásobník.Pop();
			}
			else
			{
				Console.WriteLine("Chyba!");
			}
		}

		else if (c == ']')
		{
			if (zásobník.Peek() == '[')
			{
				zásobník.Pop();
			}
			else
			{
				Console.WriteLine("Chyba!");
			}
		}
	}
	else
	{
		Console.WriteLine("toto není závorka, mistře");
	}
	
}
if (zásobník == null)
{
	Console.WriteLine("vše v pořádku, pane");
}
else
{
	Console.WriteLine("vloudila se chybička, pane");
}