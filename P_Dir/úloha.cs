Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("banán", 5);
dict["pomeranč"] = 34;
dict["rohlík"] = 87463;
dict["lovecký salám"] = 4569;
dict["ZAHRADNÍ TRAKTOR S PŘÍVĚSEM 110CCM-Zelený"] = 176;

Console.WriteLine($"banánů: {dict["banán"]}");
Console.WriteLine($"pomerančů: {dict["pomeranč"]}");
Console.WriteLine($"rohlíků: {dict["rohlík"]}");
Console.WriteLine($"loveckých salámů: {dict["lovecký salám"]}");
Console.WriteLine($"ZAHRADNÍCH TRAKTORŮ S PŘÍVĚSEM 110CCM-Zelený: {dict["ZAHRADNÍ TRAKTOR S PŘÍVĚSEM 110CCM-Zelený"]}");