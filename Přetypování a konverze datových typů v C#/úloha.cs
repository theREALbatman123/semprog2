double cislo = 5.75;
Console.WriteLine($"číslo před přetypováním: {cislo}");

int cislo2 = (int)cislo;
Console.WriteLine($"číslo po explicitním přetypování: {cislo2}");


float cislo3 = cislo2;
Console.WriteLine($"číslo po implicitním přetypování {cislo3}");


object pozdrav = "Dobrý den";
string pozdrav2 = pozdrav as string;
Console.WriteLine();
Console.WriteLine(pozdrav2);


if (pozdrav2 is string)
{
	Console.WriteLine("Ano. Toto vskutku je string.");
}
else
{
	Console.WriteLine("Ajajaj. Toto ovšem string není!");
}