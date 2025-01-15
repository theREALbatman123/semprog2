class Kniha
{
	public string Nazev { get; set; }
	public string Autor { get; set; }
	public int RokVydani { get; set; }
}

class Program
{
	static void Main()
	{
		List<Kniha> knihy = new List<Kniha>
		{
			new Kniha { Nazev = "kniha1", Autor = "Autor1", RokVydani = 1995 },
			new Kniha { Nazev = "jak se Pepa v nose dloubal", Autor = "Pepa", RokVydani = 2005 },
			new Kniha { Nazev = "H", Autor = "7", RokVydani = 5 },
			new Kniha { Nazev = "7 způsobů, jak oloupat cibuli", Autor = "Cibuloslav Česneček", RokVydani = 2018 }
		};

		var vicNezDvaTisice = knihy
			.Where(e => e.RokVydani > 2000)
			.OrderBy(e => e.Autor.Length)
			.Select(e => e.Nazev);

		foreach (var e in vicNezDvaTisice)
		{
			Console.WriteLine(e);
		}

	}
}