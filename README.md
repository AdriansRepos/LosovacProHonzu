Aplikace pro losování výherců.
Jména zadává uživatel oddělená pouze mezerou.
Počet výherců si může vybrat zadáním čísla.
Nastavena ochrana proti neočekávanému vstupu při zadávání počtu výherců:
číslo musí být rovno 1, nebo vyšší, konečný počet je řešen jako soutěžící - 1.
K ukončení aplikace slouží libovolná klávesa.

## Ukázka kódu:
```csharp
while (true)

{

&#x20;   if (int.TryParse(pocetInput, out pocet))

&#x20;   {

&#x20;       if (pocet >= 1 \&\& pocet < soutezici.Length)

&#x20;       {

&#x20;           break;

&#x20;       }

&#x20;       Console.WriteLine($"Zadej číslo mezi 1 a {soutezici.Length - 1}:");

&#x20;   }

&#x20;   else

&#x20;   {

&#x20;       Console.WriteLine("Neplatný počet. Zadej prosím celé číslo:");

&#x20;   }

&#x20;   pocetInput = Console.ReadLine();

}

**Release**
Aktuální verze: v1.0.0
Stáhnout zde: Releases
https://github.com/AdriansRepos/LosovacProHonzu/releases