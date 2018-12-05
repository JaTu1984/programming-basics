using System;

using System.IO;

namespace Harjoitustyö

{

    class Program

    {

        static void Main(string[] args)

        {

            string userAddedReferenceNumber = "";

            string refNumber = "";

            do

            {

                UserInterface();

                bool isNumber = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int caseSwitch);

                if (isNumber)

                //int caseSwitch = int.Parse(Console.ReadLine());

                {

                    switch (caseSwitch)

                    {

                        case 1:

                            Console.WriteLine();

                            Console.WriteLine("Syötä viitenumero kokonaisuudessaan");

                            refNumber = Console.ReadLine();

                            string output = refNumber.Substring(refNumber.Length - 1, 1);

                            Console.WriteLine($"{output}");

                            string alkuosa = refNumber.Substring(0, refNumber.Length - 1);

                            Console.WriteLine($"{alkuosa}");

                            string output2 = ViitenumeroTarkisteella(alkuosa);

                            if (output == output2.Substring(output2.Length - 1, 1))

                                Console.WriteLine("Viitenumero on oikein");

                            else

                                Console.WriteLine("Viitenumero on virheellinen");

                            break;

                        case 2:

                            Console.WriteLine();

                            //Console.WriteLine("Syötä viitenumeron alkuosa");
                           

                            userAddedReferenceNumber = Generator();

                            if (IsValidReferenceNumber(userAddedReferenceNumber))

                            {

                                Console.WriteLine($"{ViitenumeroTarkisteella(userAddedReferenceNumber)}");

                                Console.WriteLine("Viitenumero luotu");

                            }

                            else

                                Console.WriteLine("Syöte on virheellinen!");

                            break;

                        case 3:

                            int references = 0;

                            int i = 0;

                            string referenceNumber = "";

                            string refNumbers = "";

                            Console.WriteLine();

                            do

                            {

                                try

                                {

                                    Console.WriteLine("Syötä tiedostoon tulostettavien viitteiden lukumäärä");

                                    references = int.Parse(Console.ReadLine());

                                    break;

                                }

                                catch (Exception ex)

                                {

                                    Console.WriteLine(ex.Message);

                                }

                            } while (true);

                            do

                            {

                                Console.WriteLine("Syötä viitteen alkuosa");

                                referenceNumber = Console.ReadLine();

                                if (IsValidReferenceNumber(referenceNumber))



                                {

                                    for (i = 0; i < references; i++)

                                    {

                                        refNumbers += $"{ViitenumeroTarkisteella(referenceNumber + i)}\r\n";

                                    }

                                    string path = @"C:\TEMP\referencenumber.txt";

                                    WriteToFile(path, refNumbers);

                                    Console.WriteLine("Viitenumerot luotu! Tarkista kansio C:/TEMP/referencenumber.txt");
                                   
                                }

                                else

                                    Console.WriteLine("Virheellinen syöte");

                            } while (i < references);

                            break;

                        default:

                            Console.WriteLine(" Virhe!!!");

                            break;

                    }

                }
                Delay(5);
                //Console.Clear();

            } while (true);

        }

        static void Delay(int seconds)

        {

            for (int i = 0; i < seconds; i++)

            {

                Console.Write(".");

                System.Threading.Thread.Sleep(1000);

            }
            Console.Clear();
            //Console.WriteLine();

        }
        

            /// <summary>

            /// Tarkistaa syötetyn viitenumeron pituuden ja, että sisältää sallittuja merkkejä

            /// Palauttaa arvon true tai false

            /// </summary>

            /// <param name="check"></param>

            /// <returns></returns>

            static bool IsValidReferenceNumber(string check)

        {

            bool retValue = false;

            if (check.Length >= 3 && check.Length <= 19)

                retValue = true;

            retValue = int.TryParse(check, out int refNumber);

            return retValue;

        }

        public static string ViitenumeroTarkisteella(string begin)

        {

            int sum = 0;

            //Viitestandarin mukaiset painotukset lopusta lukien (pl. tarkiste)

            var weight = new int[] { 7, 3, 1 };

            //painojen laskuri

            int weightIndex = 0;

            //Käydään merkit läpi lopusta alkuun (jolloin ei tarvitse välittää etunollista)

            for (int c = begin.Length - 1; c >= 0; c--)

            {

                sum += weight[weightIndex++] * int.Parse(begin.Substring(c, 1));

                if (weightIndex >= weight.Length) { weightIndex = 0; }

            }

            //Palautetaan viitteen alkuosa lisättynä lasketulla tarkisteella

            return begin + ((10 - sum % 10) % 10).ToString();

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
        static void UserInterface()
        {
            //Console.WriteLine();

            Console.WriteLine("Kansallinen viitenumero");

            Console.WriteLine("Valitse toiminto [1-3]: ");

            Console.WriteLine($"1. Haluan tarkastaa kansallisen viitenumeron");

            Console.WriteLine($"2. Haluan luoda kansallisen viitenumeron");

            Console.WriteLine($"3. Haluan määrittää monta viitenumeroa luodaan ja tulostetaan tiedostoon");
        }
        static string Generator()
        {
            Random rnd = new Random();
            int length = rnd.Next(3, 19);
            Console.WriteLine(length);
            string refNumber = "";
            for (int i = 0; i < length; i++)
            {
                refNumber += rnd.Next(10);
            }
            return refNumber;
        }

    }

}
