Queue<string> IMPORTANT = new Queue<string> ();
Queue<string> NOTIMPORTANT = new Queue<string>();
string vstup;
while (true)
{
	vstup = Console.ReadLine ();
	if (vstup == "STOP!!")
	{
		break;
	}
	if (vstup.StartsWith("vp"))
	{
		IMPORTANT.Enqueue(vstup);
	}
	else if (vstup.StartsWith("np"))
	{
		NOTIMPORTANT.Enqueue(vstup);
	}
	else
	{
		Console.WriteLine("imbecile");
	}
}
int cislicko = 1;
while (IMPORTANT.Count > 0)
{
	Console.WriteLine(cislicko + IMPORTANT.Dequeue());
	cislicko ++;
}
while (NOTIMPORTANT.Count > 0)
{
	Console.WriteLine(cislicko + NOTIMPORTANT.Dequeue());
	cislicko++;
}