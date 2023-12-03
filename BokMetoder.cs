using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;

namespace Bokhylla
{
public static class BokMetoder
{
// Metod för att lägga till en ny bok i bokhyllan
public static void LäggTillBok(List<Bok> minBokhylla)
{
    Console.WriteLine("Ange information om din bok");
    Console.WriteLine("Ange titel: ");
    string titel = Console.ReadLine();

    Console.WriteLine("Ange författare: ");
    string författare = Console.ReadLine();

    Console.WriteLine("Ange årtal:");
    int årtal;
    while (!int.TryParse(Console.ReadLine(), out årtal) || årtal < 0)
    {
        Console.WriteLine("Ogiltigt årtal. Ange ett positivt heltal.");
    }

    Console.WriteLine("Vilken typ av bok är det? [1] Skönlitteratur, [2] Facklitteratur, [3] Fantasy?");
    int genreVal;
    while (!int.TryParse(Console.ReadLine(), out genreVal) || genreVal < 1 || genreVal > 3)
    {
        Console.WriteLine("Ogiltigt val. Ange en siffra mellan 1-3.");
    }
    // Skapar en ny bok baserat på användarens val
    Bok nyBok;

    if (genreVal == 1)
    {
        Console.WriteLine("Hur många sidor är boken:");
        int antalSidor = int.Parse(Console.ReadLine());
        nyBok = new Skönlitteratur(titel, författare, årtal, antalSidor);
    }
    else if (genreVal == 2)
    {
        Console.WriteLine("Vilka är bokens huvudpersoner:");
        string huvudpersoner = Console.ReadLine();
        nyBok = new Facklitteratur(titel, författare, årtal, huvudpersoner);
    }
    else if (genreVal == 3)
    {
        Console.WriteLine("Ange det fiktiva universumet för Fantasy-boken:");
        string fiktivtUniversum = Console.ReadLine();
        nyBok = new Fantasy(titel, författare, årtal, fiktivtUniversum);
    }
    else
    {
        Console.WriteLine("Ogiltligt val. Ange en siffra mellan 1-3.");
        return;
    }
    // Lägger till nya boken i bokhyllan
    minBokhylla.Add(nyBok);
    Console.WriteLine("Boken har lagts till i bokhyllan!");
}
    // Metod för att visa alla böcker i bokhyllan
    public static void VisaBöcker(List<Bok> minBokhylla)
    {   // Hanterar en tom bokhylla
        if (minBokhylla.Count == 0)
        {
            Console.WriteLine("Du har inga böcker i bokhyllan");
            Console.WriteLine("Vill du lägga till en ny bok? (J/N)");
            string svar = Console.ReadLine().ToUpper();
        
            if (svar.ToUpper() == "J")
            {
                LäggTillBok(minBokhylla);
            }
        return;
        }

        Console.WriteLine("Bokhyllan innehåller följande böcker:");
        // Loopar genom bokhyllan och skriver ut varje bok
        foreach (var bok in minBokhylla)
        {
            Console.WriteLine(bok);
        
            if (bok is Skönlitteratur skönlitteraturBok)
            {
                Console.WriteLine($"Antal sidor: {skönlitteraturBok.AntalSidor}");
            }
            else if (bok is Facklitteratur facklitteraturBok)
            {
                Console.WriteLine($"Huvudpersoner: {facklitteraturBok.Huvudpersoner}");
            }
            else if (bok is Fantasy fantasyBok)
            {
                Console.WriteLine($"Fiktivt universum: {fantasyBok.FiktivtUniversum}");
            }
        }
    }
    // Metod för att radera allt innehåll i bokhyllan med en nedräkning
    public static void RaderaBokhylla(List<Bok> minBokhylla)
    {
        Console.WriteLine("Är du helt säker på att du vill radera dina böcker? (J/N)");
        string svar = Console.ReadLine().ToUpper();
        if (svar == "J")
        {
            Console.WriteLine("Radering av din bokhylla börjar om 3 sekunder...");
            Thread.Sleep(1000);
            Console.WriteLine("2 sekunder..");
            Thread.Sleep(1000);
            Console.WriteLine("1 sekund..");
            minBokhylla.Clear();
            Console.WriteLine("Alla dina böcker har raderats från bokhyllan.");
        }
        else if (svar == "N")
        {
            Console.WriteLine("Dina böcker finns kvar i bokhyllan");
        }
        else
        {
            Console.WriteLine("Ogiltligt svar. Svara med J eller N");
        }
    }
}
}
