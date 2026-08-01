# Aplikace pro losování výherců.

## Funkce programu:
- Jména zadává uživatel oddělená pouze mezerou.
- Počet výherců si může vybrat zadáním čísla.
- Nastavena ochrana proti neočekávanému vstupu při zadávání počtu výherců:
  - číslo musí být rovno 1, nebo vyšší, 
  - konečný počet je řešen jako soutěžící - 1.
- K ukončení aplikace slouží libovolná klávesa.

## Ukázka kódu:
```csharp
while (true)

{

   if (int.TryParse(pocetInput, out pocet))

   {

       if (pocet >= 1 \&\& pocet < soutezici.Length)
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
```

### Release

**v1.0.0** – První verze programu pro losování výherců.  
[Stáhnout zde](https://github.com/AdriansRepos/LosovacProHonzu/releases/tag/v1.0.0)