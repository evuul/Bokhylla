using System;
using System.Collections.Generic;

namespace Bokhylla
{
    class Program
    {
        // Lista för att lagra böcker i bokhyllan
        static List<Bok> minBokhylla = new List<Bok>();

        static void Main(string[] args)
        {           
            bool isRunning = true;

            // Huvudloop för programmet
            while (isRunning)
            {
                // Användarinteraktion: Huvudmeny
                Console.WriteLine("Välkommen till bokhyllan!");
                Console.WriteLine("[1] Lägg till en ny bok");
                Console.WriteLine("[2] Visa alla böcker");
                Console.WriteLine("[3] Radera allt innehåll i bokhyllan");
                Console.WriteLine("[4] Avsluta program");

                // Användarens val
                string val = Console.ReadLine();

                // Hantera användarens val med en switch-sats
                switch (val)
                {
                    case "1":
                        // Anropar metoden för att lägga till en ny bok
                        BokMetoder.LäggTillBok(minBokhylla);
                        break;
                    case "2":
                        // Anropar metoden för att visa alla böcker
                        BokMetoder.VisaBöcker(minBokhylla);
                        break;
                    case "3":
                        // Anropar metoden för att radera allt innehåll i bokhyllan
                        BokMetoder.RaderaBokhylla(minBokhylla);
                        break;
                    case "4":
                        // Avsluta programmet
                        isRunning = false;
                        break;
                    default:
                        // Felmeddelande vid ogiltigt val
                        Console.WriteLine("Ogiltligt val. Välj mellan 1-4");
                        break;
                }
            }
        }
    }
}
