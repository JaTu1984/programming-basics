using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace henktunlasku
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Anna henkilötunnus kokonaisena tai ilman viimeistä merkkiä (PPKKVV-ZZZQ)");
                Console.Write("tai tyhjä lopettaaksesi: ");
                string tunnusSyöte = Console.ReadLine().ToUpper();

                //Poistutaan silmukasta jos tyhjä syöte
                if (string.IsNullOrWhiteSpace(tunnusSyöte)) break;

                if (new Regex("\\d{6}[-+A]\\d{3}[0-9A-Y]?").IsMatch(tunnusSyöte))
                {
                    Console.WriteLine("Syöte on oikeassa muodossa, siirrytään laskemaan se");

                    var tarkiste = laskeTarkiste(tunnusSyöte);
                    string sukupuoli = (tunnusSyöte[9] % 2 == 0) ? "nainen" : "mies";

                    if (tunnusSyöte.Length == 10)
                    {
                        Console.WriteLine("Tunnukseen tuleva tarkistusmerkki on " + tarkiste);
                        Console.WriteLine("ja tunnuksen haltija on " + sukupuoli);
                    }
                    else if (tunnusSyöte[10] == tarkiste)
                        Console.WriteLine("Tunnus on oikein ja sen haltija on " + sukupuoli);
                    else
                        Console.WriteLine("Virheellinen tunnus!");
                    /* Jos tunnus on väärin, niin ei ole järkevää ilmoittaa
                       sukupuolta, sillä voihan olla että juuri ko. merkki
                       on väärin. */
                }
                else
                {
                    Console.WriteLine("Syöte ei ollut oikeassa muodossa!");
                }
                Console.WriteLine();
            }
        }

        static char laskeTarkiste(string tunnus)
        {
            int luku = int.Parse(tunnus.Substring(0, 6) + tunnus.Substring(7, 3));
            //tarkistusmerkit
            return "0123456789ABCDEFHJKLMNPRSTUVWXY"[luku % 31];
        }
    }
}