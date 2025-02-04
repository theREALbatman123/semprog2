List<string> slova = new List<string> { "jablko", "banán", "kiwi", "pomeranč", "hruška" };
var dlouhy = slova	
.OrderBy(e => e.Length);
foreach (var e in dlouhy)
{
	Console.WriteLine(e);
}