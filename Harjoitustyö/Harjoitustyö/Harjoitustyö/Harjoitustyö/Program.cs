using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {

        
        static void Main(string[] args)
        {

            string userAddedReferenceNumber = "";
            string viitenumero = "";
            
            do
            {

                Console.WriteLine();
                Console.WriteLine("Kansallinen viitenumero");

                Console.WriteLine("Valitse toiminto [1-3]: ");

                Console.WriteLine($"1. Haluan tarkastaa kansallisen viitenumeron");
                Console.WriteLine($"2. Haluan luoda kansallisen viitenumeron");
                Console.WriteLine($"3. Haluan määrittää monta viitenumeroa luodaan ja tulostetaan tiedostoon");

                bool isNumber = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int caseSwitch);
                if (isNumber)

                //int caseSwitch = int.Parse(Console.ReadLine());
                {
                    switch (caseSwitch)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Syötä viitenumero kokonaisuudessaan");
                            viitenumero = Console.ReadLine();
                            string output = viitenumero.Substring(viitenumero.Length - 1, 1);
                            Console.WriteLine($"{output}");
                            string alkuosa = viitenumero.Substring(0, viitenumero.Length -1);
                            Console.WriteLine($"{alkuosa}");
                            string output2 = ViitenumeroTarkisteella(alkuosa);
                            if (output == output2.Substring(output2.Length-1,1))
                            Console.WriteLine("Viitenumero on oikein");
                            else
                                Console.WriteLine("Viitenumero on virheellinen");
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Syötä viitenumeron alkuosa");
                            userAddedReferenceNumber = Console.ReadLine();
                            Console.WriteLine($"{ViitenumeroTarkisteella(userAddedReferenceNumber)}");
                            Console.WriteLine("Viitenumero luotu");
                            break;
                        case 3:
                            int viitteet = 0;
                            int i = 0;
                            string referenceNumber = "";
                            string refNumbers = "";
                            Console.WriteLine();
                            Console.WriteLine("Syötä tiedostoon tulostettavien viitteiden lukumäärä");
                            viitteet = int.Parse(Console.ReadLine());
                            Console.WriteLine("Syötä viitteen alkuosa");
                            referenceNumber = Console.ReadLine();

                            for (i = 0; i < viitteet; i++)
                            {
                                refNumbers += $"{ViitenumeroTarkisteella(referenceNumber + i)}\n"; 
                            }
                            string path = @"C:\TEMP\referencenumber.json";
                            WriteToFile(path, refNumbers);
                            Console.WriteLine("Viitenumerot luotu! Tarkista kansio C:/TEMP/referencenumber.json");
                            break;
                        default:
                            Console.WriteLine("Virhe!!!");
                            break;
                    }
                }
                //Console.Clear();

            } while (true);

            
        }


        static void Delay()

        {

            for (int i = 0; i < 3; i++)

            {

                Console.Write(".");

                System.Threading.Thread.Sleep(1000);

            }

            Console.WriteLine();

        }
        public static string ViitenumeroTarkisteella(string alku)
        {
            int summa = 0;
            //Viitestandarin mukaiset painotukset lopusta lukien (pl. tarkiste)
            var painotus = new int[] { 7, 3, 1 };
            //painojen laskuri
            int painoIndeksi = 0;

            //Käydään merkit läpi lopusta alkuun (jolloin ei tarvitse välittää etunollista)
            for (int c = alku.Length - 1; c >= 0; c--)
            {
                summa += painotus[painoIndeksi++] * int.Parse(alku.Substring(c, 1));
                if (painoIndeksi >= painotus.Length) { painoIndeksi = 0; }
            }
            //Palautetaan viitteen alkuosa lisättynä lasketulla tarkisteella
            return alku + ((10 - summa % 10) % 10).ToString();
        }  /// <summary>

        /// Write to file by using StreamWriter Class

        /// Create a new file

        /// string filePath is 

        /// </summary>

        /// <param name="filePath"></param>

        static void WriteToFile(string filePath, string data)

        {

            using (StreamWriter sw = new StreamWriter(filePath))

            {

                sw.WriteLine("Tulostetut viitenumerot");

                sw.WriteLine(DateTime.Now.ToString());

                sw.WriteLine($"{data}");

            }

        }
    }
}
