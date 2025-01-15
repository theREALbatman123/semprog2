List<int> cisla = new List<int> { 5, 15, 8, 22, 1, 11 };
var velky = cisla
	.Where(n => n > 10);
Console.WriteLine("čísla větší než 10:");
foreach (var n in velky)
{ 
	Console.WriteLine(n);
}