int cislo = 456;
object box  = cislo;
Console.WriteLine($"Hodnota po zaboxování: {box}");

    
int number = (int)box;
Console.WriteLine($"Hodnota po odboxování: {number}");

if ( cislo == number )
{
    Console.WriteLine("Skvělá práce. Vyšlo to");
}
else
{
    Console.WriteLine("ups.. Něco se mepovedlo");
}