using System;
using System.Collections.Generic;
using System.IO;

namespace UtazasCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Utazasok> eredmenyek = Beolvas("utazasok.csv");
            foreach (var adat in eredmenyek)
            {
                Console.WriteLine($"Id: {adat.Id}, Ország: {adat.Orszag}, Hónap: {adat.Honap}, Nap: {adat.Nap}, Hossz: {adat.Hossz}, Ár: {adat.Ar}Ft, Ellátás: {adat.Ellatas}");
            }

            Console.ReadLine();
        }

        static List<Utazasok> Beolvas(string fajlnev)   
        {
            List<Utazasok> eredmenyek = new List<Utazasok>();

            try
            {
                using (StreamReader sr = new StreamReader(fajlnev))
                {
                    string sor;
                    while ((sor = sr.ReadLine()) != null)
                    {
                        if (sor.StartsWith("id,orszag,honap,nap,hossz,ar,ellatas"))
                            continue;

                        Utazasok eredmeny = new Utazasok(sor);
                        eredmenyek.Add(eredmeny);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba: {e.Message}");
            }

            return eredmenyek;
        }
    }
}