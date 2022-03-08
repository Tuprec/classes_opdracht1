using System;
using System.Collections;
using System.Collections.Generic;

namespace classes_opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gegevens_L Leerling = new Gegevens_L();
            string strAnswer;
            Console.Write("Wilt u iets aanpassen?(Y/N) ");
            strAnswer = Console.ReadLine().ToUpper();
            if (strAnswer == "Y")
            {
                Leerling.Aanpassen(Leerling);
            }
            Leerling.Weergeven(Leerling);
        }
    }
}
