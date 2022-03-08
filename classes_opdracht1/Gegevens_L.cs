using System;
using System.Collections.Generic;
using System.Text;

namespace classes_opdracht1
{
    class Gegevens_L
    {
        public string strVoornaam;
        public string strAchternaam;
        public string strKlas;
        public Gegevens_L()
        {
            Console.Write("Geef uw voornaam: ");
            strVoornaam = Console.ReadLine();
            Console.Write("Geef uw achternaam: ");
            strAchternaam = Console.ReadLine();
            Console.Write("Geef uw klas: ");
            strKlas = Console.ReadLine();
            Console.Clear();
        }
        public void Aanpassen(Gegevens_L leerling)
        {
            Console.Write("Geef uw voornaam: ");
            strVoornaam = Console.ReadLine();
            Console.Write("Geef uw achternaam: ");
            strAchternaam = Console.ReadLine();
            Console.Write("Geef uw klas: ");
            strKlas = Console.ReadLine();
            Console.Clear();
        }

        public void Weergeven(Gegevens_L leerling)
        {
            Console.WriteLine($"Voornaam leerling: {strVoornaam}");
            Console.WriteLine($"Achternaam leerling: {strAchternaam}");
            Console.WriteLine($"Klas leerling: {strKlas}");
        }
    }
}
