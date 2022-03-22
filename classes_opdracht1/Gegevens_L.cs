using System;
using System.Collections.Generic;
using System.Text;

namespace classes_opdracht1
{
    class Gegevens_L
    {
        private string strVoornaam;
        private string strAchternaam;
        private string strKlas;

        public string STRVOORNAAM
        {
            get { return strVoornaam; }
            set { strVoornaam = value; }
        }
        public string STRACHTERNAAM
        {
            get { return strAchternaam; }
            set { strAchternaam = value; }
        }
        public string STRKLAS
        {
            get { return strKlas; }
            set { strKlas = value; }
        }


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
            leerling.STRVOORNAAM = Console.ReadLine();
            Console.Write("Geef uw achternaam: ");
            leerling.STRACHTERNAAM = Console.ReadLine();
            Console.Write("Geef uw klas: ");
            leerling.STRKLAS = Console.ReadLine();
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
