using System;

namespace Bokhylla
{
    // Basklassen för alla typer av böcker
    public class Bok
    {
        // Egenskap för bokens titel, författare, årtal och genre
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Årtal { get; set; }
        public string Genre { get; set; }

        // Konstruktor för att skapa en ny bok med angiven information
        public Bok(string titel, string författare, int årtal, string genre)
        {
            Titel = titel;
            Författare = författare;
            Årtal = årtal;
            Genre = genre;
        }
        // Överskriden ToString metod för att skapa en textrepresentation av boken
        public override string ToString()
        {
            return $" Titel: {Titel}, Författare: {Författare}, Årtal: {Årtal}, Genre: {Genre}";
        }
    }

    public class Skönlitteratur : Bok
    {
        // Egenskap för antal sidor i skönlitteraturboken
        public int AntalSidor { get; set; }

        public Skönlitteratur(string titel, string författare, int årtal, int antalSidor) : base(titel, författare, årtal, "Skönlitteratur")
        {
            AntalSidor = antalSidor;
        }
    }
    // Underklass för Facklitteratur som ärver från Bok
    public class Facklitteratur : Bok
    {
        // Egenskap för huvudpersoner i facklitteratyr
        public string Huvudpersoner { get; set; }

        public Facklitteratur(string titel, string författare, int årtal, string huvudpersoner) : base(titel, författare, årtal, "Facklitteratur")
        {
            Huvudpersoner = huvudpersoner;
        }
    }
    // Underklass för fantasy som ärver från Bok
    public class Fantasy : Bok
    {
        // Egenskap för fiktivtuniversum i fantasy
        public string FiktivtUniversum { get; set; }

        public Fantasy(string titel, string författare, int årtal, string fiktivtUniversum) : base(titel, författare, årtal, "Fantasy")
        {
            FiktivtUniversum = fiktivtUniversum;
        }
    }
}
