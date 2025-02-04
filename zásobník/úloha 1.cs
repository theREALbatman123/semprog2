Stack<char> zasobník = new Stack<char>();
Console.WriteLine("napiš slovíčko: ");
String slovo  = Console.ReadLine();
char[] znaky = slovo.ToArray();

foreach (char c in znaky)
{
	zasobník.Push(c);
}
Console.WriteLine();
foreach (char c in znaky)
{
	Console.Write(zasobník.Pop());
}