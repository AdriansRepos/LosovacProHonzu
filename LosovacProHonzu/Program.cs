Console.WriteLine("Zadej soutěžící oddělené mezerou:");
string? vstup = Console.ReadLine();

string[] soutezici = vstup
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.Write("Kolik výherců chceš vylosovat: ");
string? pocetInput = Console.ReadLine();
int pocet;

while (true)
{
    if (int.TryParse(pocetInput, out pocet))
    {
        if (pocet >= 1 && pocet < soutezici.Length)
        {
            break;
        }

        Console.WriteLine($"Zadej číslo mezi 1 a {soutezici.Length - 1}:");
    }
    else
    {
        Console.WriteLine("Neplatný počet. Zadej prosím celé číslo:");
    }

    pocetInput = Console.ReadLine();
}

Random r = new Random();

var vyherci = soutezici
    .OrderBy(s => r.Next())
    .Take(pocet);

Console.WriteLine("Výherci:");
foreach (string v in vyherci)
{
    Console.WriteLine(v);
}

Console.WriteLine();
Console.WriteLine("Losování ukončeno. \nStiskni libovolnou klávesu pro uončení programu...");
Console.ReadKey();
